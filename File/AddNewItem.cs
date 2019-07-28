using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_Project
{
    public partial class AddNewItem : Form
    {
        private Form1 form;
        public AddNewItem(Form1 aForm)
        {
            InitializeComponent();
            this.form = aForm;
            this.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool check = true;
            if(nameTextBox.Text == "")
            {
                check = false;
                nameValidation.Text = "Invalid";
            }
            else
            {
                nameValidation.Text = "";
            }

            if (lengthTextBox.Text == "")
            {
                check = false;
                lengthValiddation.Text = "Invalid";
            }
            else
            {
                lengthValiddation.Text = "";
            }
            if (quanityTextBox.Text == "")
            {
                check = false;
                quanityValiddation.Text = "Invalid";
            }
            else
            {
                quanityValiddation.Text = "";
            }


            string name = nameTextBox.Text;
                double length =0;
                int quanity =0;
            if (check)
            {
                try
                {
                    length = Convert.ToDouble(lengthTextBox.Text);
                }
                catch (Exception l1)
                {
                    lengthValiddation.Text = "Not a number";
                    check = false;
                }
                try
                {
                    quanity = Convert.ToInt32(quanityTextBox.Text);
                }
                catch (Exception q1)
                {
                    quanityValiddation.Text = "Not a number";
                    check = false;
                }
            }
            if (check)
            {
                if (length <= 0 || quanity <= 0)
                {
                    MessageBox.Show("Please enter number greater than 0", "Negative number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
            }
            if (check)
            {
                if(tagTextBox.Text == "")
                {
                    tagTextBox.Text = "NONE";
                }
                double time = Convert.ToDouble(length * 0.001 * 8.5 * 8.5 * 0.001 * 0.001 / 2 * 7900 / 5 * 60 * 60);
                Item newItem = new Item(name, length, time, quanity);
                newItem.filename = tagTextBox.Text;
                this.form.listItemBox.Items.Add(newItem);
                this.form.updateItem();
                MessageBox.Show("New Item was added to the program", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false ;
                this.form.updateItem();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
