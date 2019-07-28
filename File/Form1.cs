using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ICT_Project
{
    public partial class Form1 : Form
    {
        Item clickedItem;
        ArrayList listJoin = new ArrayList();
        public System.Windows.Forms.ListBox listItemBox;
        Begin previousWindow;
        public Form1(Begin window)
        {
            InitializeComponent();
            this.Visible = true;
            this.listItemBox = this.ImportedItemListBox;
            this.previousWindow = window;
        }

        public void updateTotalTime()
        {
            double totalTime = 0;
            for(int i =0; i < ImportedItemListBox.Items.Count;i++)
            {
                totalTime += (((Item)ImportedItemListBox.Items[i]).time * ((Item)ImportedItemListBox.Items[i]).quanity);
            }
            double result = totalTime / 60;
            TotalTime.Text = Math.Round(result, 2, MidpointRounding.AwayFromZero) + " minutes";
        }


        private void ImportedItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //This try-catch prevent the exception in index change when implement soft funciton.
                clickedItem = (Item)ImportedItemListBox.SelectedItem;
                LengthTextBox.Text = clickedItem.len + "";
                picture.LoadFile(clickedItem.picture);
                DetailTitle.Text = "Item: " + clickedItem.name;
                this.TimeBox.Text = clickedItem.time + "";
                this.quanityTextBox.Text = clickedItem.quanity + "";
                updateTotalTime();
            }
            catch( Exception e2)
            {
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            //Allow only PDF import
            OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                string fileName = ofd.SafeFileName.ToString().Substring(0, ofd.SafeFileName.ToString().Length-4);
                PDDocument doc = PDDocument.load(path);
                PDFTextStripper stripper = new PDFTextStripper();
                string paragraph = stripper.getText(doc);
                string[] lines = paragraph.Split('\n');
                //Find the line in an array to find Item information
                string target = "(kg)";
                int i = 0;  //Index begin of data in an array
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j].Contains(target))
                    {
                        i = j;
                    }
                }
                int i1 = i + 1;     //Last index of data in an array
                string target1 = "TOTAL";
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j].Contains(target1) && lines[j].Length < 14)
                    {

                        i1 = j;
                        break;
                    }
                }
                i = i + 1;
                //An array to store data
                string[] joins = new string[i1 - i];
                int newI = 0;
                for (int j = i; j < i1; j++)
                {
                    joins[newI] = lines[j];
                    newI += 1;
                }

                //Convert each line to Item.
                for (int j = 0; j < joins.Length; j++)
                {
                    string[] eachJoin = joins[j].Split(' ');
                    Item newItem = new Item(eachJoin[0], Convert.ToDouble(eachJoin[2]), 0, Convert.ToInt32(eachJoin[1]));
                    newItem.filename = fileName;
                    checkRestriction(newItem);
                    if (Convert.ToDouble(eachJoin[2]) < 2000)
                    {
                        this.listJoin.Add(newItem);
                    }
                }

                //ADd to listBox
                for (int j = 0; j < listJoin.Count; j++)
                {
                    //Check existing item
                    bool check = true;
                    for (int k = 0; k < ImportedItemListBox.Items.Count; k++)
                    {
                        if (ImportedItemListBox.Items[k].ToString().Equals(listJoin[j].ToString()))
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        ImportedItemListBox.Items.Add(listJoin[j]);
                        LengthTextBox.Text = ((Item)listJoin[j]).len + "";
                        ((Item)listJoin[j]).time = Convert.ToDouble(((Item)listJoin[j]).len * 0.001 * Convert.ToDouble(SteamThick.Text) * Convert.ToDouble(SteamThick.Text) * 0.001 * 0.001 / 2 * 7900 / 5 * 60 * 60);
                        ((Item)listJoin[j]).picture = path;
                    }
                }
            }
            updateTotalTime();
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            if (this.CrossLine.Text == "0")
            {
                CrossLine.Text = "1";
            }
            //CrossLine^2+CrossLine^2
            this.SteamThick.Text = (Convert.ToDouble(CrossLine.Text)) * (Convert.ToDouble(CrossLine.Text)) + (Convert.ToDouble(CrossLine.Text)) * (Convert.ToDouble(CrossLine.Text)) + "";
            //square root
            this.SteamThick.Text = Math.Sqrt(Convert.ToDouble(SteamThick.Text)) + "";
        }

        private void quanityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.quanityTextBox.Text == "0")
                {
                    quanityTextBox.Text = "1";
                }
                //*0.001 mean become meter
                //(Length*0.001 )* (SeamThickness*0.001)^2/2=volum

                //   /5*(60*60) is the time
                //volum*Density/5*(60*60)=time
                //time *2 becasue fount and back
                //this.TimeBox.Text = (Convert.ToDouble(this.LengthTextBox.Text) * .001 * Convert.ToDouble(this.SteamThick.Text) * .001 * Convert.ToDouble(this.SteamThick.Text) * .001 / 2 * 7900 / 5 * 60 * 60) * 2 + "";

                this.TimeBox.Text = (Convert.ToDouble(this.LengthTextBox.Text) * .001 * Convert.ToDouble(this.SteamThick.Text) * .001 * Convert.ToDouble(this.SteamThick.Text) * .001 / 2 * 7900 / 5 * 60 * 60) * 2 + "";

            }
            catch (Exception s)
            {
                MessageBox.Show("Quanity must be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.CrossLine.ReadOnly = false;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string path = "";
            SaveFileDialog file = new SaveFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName.ToString();
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }


                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Name";
                xlWorkSheet.Cells[1, 2] = "Length";
                xlWorkSheet.Cells[1, 3] = "Time";
                xlWorkSheet.Cells[1, 4] = "Quanity";
                xlWorkSheet.Cells[1, 6] = "Total Time:";

                //Put Item to file
                for(int i=0; i < ImportedItemListBox.Items.Count; i++)
                {
                    xlWorkSheet.Cells[i+2, 1] = ((Item)ImportedItemListBox.Items[i]).name;
                    xlWorkSheet.Cells[i+2, 2] = ((Item)ImportedItemListBox.Items[i]).len;
                    xlWorkSheet.Cells[i+2, 3] = ((Item)ImportedItemListBox.Items[i]).time;
                    xlWorkSheet.Cells[i+2, 4] = ((Item)ImportedItemListBox.Items[i]).quanity;
                }
                xlWorkSheet.Cells[2, 6] = TotalTime.Text;

                xlWorkBook.SaveAs(path+ ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                MessageBox.Show("Save successfully.");
            }




            //everytime make item object see name of item
            //see is that name in data set
            //if (true ) replace len with that number

        }

        private void SaveQuanityButton_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(quanityTextBox.Text);
            ((Item)ImportedItemListBox.SelectedItem).quanity = value;
            updateTotalTime();
        }

        private void SaveLenButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(LengthTextBox.Text);
                ((Item)ImportedItemListBox.SelectedItem).len = value;
                //Re-calculate time
                ((Item)ImportedItemListBox.SelectedItem).time = Convert.ToDouble(((Item)ImportedItemListBox.SelectedItem).len * 0.001 * Convert.ToDouble(SteamThick.Text) * Convert.ToDouble(SteamThick.Text) * 0.001 * 0.001 / 2 * 7900 / 5 * 60 * 60);
                updateTotalTime();

                //Write to file
                string path = "D:\\RestrictionValue.txt";
                string data = ((Item)ImportedItemListBox.SelectedItem).name + "\t" + value;
                if (File.Exists(path))
                {   //File exist
                    File.AppendAllText(path, Environment.NewLine+ data);
                }
                else {
                    File.WriteAllText(path, data);
            }
            

            }
            catch (Exception e3)
            {
                MessageBox.Show("Invalid input length", "Input not a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void sortFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sortFunction.SelectedItem.Equals("Item length -Descending"))
            {
                this.sortByLength();
                this.reverseListBox();
            }
            else if (this.sortFunction.SelectedItem.Equals("Item length -Ascending"))
            {
                this.sortByLength();
            }
            else if (this.sortFunction.SelectedItem.Equals("Item time -Descending"))
            {
                this.sortByTime();
                this.reverseListBox();

            }
            else if (this.sortFunction.SelectedItem.Equals("Item time -Ascending"))
            {
                this.sortByTime();
            }
            else if (this.sortFunction.SelectedItem.Equals("File name(a->z)"))
            {
                this.listBoxSoftByName();
                this.reverseListBox();
             }
            else if (this.sortFunction.SelectedItem.Equals("File name(z->a)"))
            {
                this.listBoxSoftByName();
            }


            updateTotalTime();
        }

        //Method to soft
        public void sortByLength()
        {
            List<Item> newList = new List<Item>();  //Create new list to store sorted items.
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                Item minLength = (Item)this.ImportedItemListBox.Items[i];
                for (int j = i; j < this.ImportedItemListBox.Items.Count; j++) //This loop to find the min weight and swap the min with the first postion.
                {
                    if (((Item)this.ImportedItemListBox.Items[j]).len < minLength.len)
                    {
                        //Swap position
                        Item temp = minLength;
                        minLength = (Item)this.ImportedItemListBox.Items[j];
                        this.ImportedItemListBox.Items[j] = temp;
                    }
                }
                //Swap index
                newList.Add(minLength);
            }
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                this.ImportedItemListBox.Items[i] = newList[i];
            }
        }

        public void sortByTime()
        {
            List<Item> newList = new List<Item>();  //Create new list to store sorted items.
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                Item minTime = (Item)this.ImportedItemListBox.Items[i];
                for (int j = i; j < this.ImportedItemListBox.Items.Count; j++) //This loop to find the min weight and swap the min with the first postion.
                {
                    if (((Item)this.ImportedItemListBox.Items[j]).time < minTime.time)
                    {
                        //Swap position
                        Item temp = minTime;
                        minTime = (Item)this.ImportedItemListBox.Items[j];
                        this.ImportedItemListBox.Items[j] = temp;
                    }
                }
                //Swap index
                newList.Add(minTime);
            }
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                this.ImportedItemListBox.Items[i] = newList[i];
            }
        }


        private void reverseListBox()
        {
            //This method is to reverse ImportedItemListBox. It is used for sort function.
            ArrayList reverseList = new ArrayList();
            //Reverse items in ImportedItemListBox to a list.
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                reverseList.Add((Item)this.ImportedItemListBox.Items[i]);
            }

            reverseList.Reverse();
            //Copy list to ImportedItemListBox
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                this.ImportedItemListBox.Items[i] = reverseList[i];
            }
        }

        private void listBoxSoftByName()
        {
            List<Item> newList = new List<Item>();  //Create new list to store sorted items.
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                Item minName = (Item)this.ImportedItemListBox.Items[i];
                for (int j = i; j < this.ImportedItemListBox.Items.Count; j++) //This loop to find the min weight and swap the min with the first postion.
                {
                    if ( ((Item)this.ImportedItemListBox.Items[j]).name.CompareTo(minName.name) >0)
                    {
                        //Swap position
                        Item temp = minName;
                        minName = (Item)this.ImportedItemListBox.Items[j];
                        this.ImportedItemListBox.Items[j] = temp;
                    }
                }
                //Swap index
                newList.Add(minName);
            }
            for (int i = 0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                this.ImportedItemListBox.Items[i] = newList[i];
            }
        }

        //Check Restriction
        public void checkRestriction(Item anItem)
        {
            try
            {   //Prevent no restriction(No file found).
                string path = "D:\\RestrictionValue.txt";
                string[] lines = System.IO.File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] restrictedItem = line.Split('\t');
                    if (restrictedItem[0] == anItem.name)
                    {
                        anItem.len = Convert.ToInt32(restrictedItem[1]);
                    }
                }
            }
            catch (Exception e) { };
        }

        //Add new item from new window
        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i < this.ImportedItemListBox.Items.Count; i++)
            {
                listItemBox = this.ImportedItemListBox;
            }
            AddNewItem newAddItemWindow = new AddNewItem(this);
        }
            
        public void updateItem()
        {
            this.ImportedItemListBox = this.listItemBox;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItem = new ListBox.SelectedObjectCollection(this.ImportedItemListBox);
            if (this.ImportedItemListBox.SelectedIndex != -1)
            {
                for (int i = selectedItem.Count - 1; i >= 0; i--)
                    this.ImportedItemListBox.Items.Remove(selectedItem[i]);
            }

            updateTotalTime();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousWindow.Visible = true;
        }
    }
    
}
