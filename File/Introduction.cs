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
    public partial class Introduction : Form
    {
        Begin previousWindow;
        public Introduction(Begin Window)
        {
            InitializeComponent();
            this.Visible = true;
            this.previousWindow = Window;
        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            ictProjectText.Text = "The purpose for this programme is for ICT Project.Special thanks to SA Structual for helping us complete this programme and having an exellent workplace experience."+
                "\nThis programme can import PDF extension file and calculate processing time for each weld." +
                "\nFor each PDF file, the progamme read data table and load it into system and estimate time process for each part."+
                "\nEach part will be loaded and display in as a list. To view part, click on the name of part and this programme displays information and orginal PDF file as well.";
            organisationText.Text = "\t\tSA Structural" +
                "\n\t     Sponsor:Chris Antoniadis\n\t     Supervisor: Ngoc-Han Vu\n\t     Academic Supervisor: Jan Stanek";
            studentText.Text = "Student: Anthony Fung\nStudent: Tran Xuan Tung NGUYEN";
            studentText.Text += "\nAuthor: \nCore Programmer: Tran Xuan Tung NGUYEN\n" +
                "Idea contributor, Fomular creator and programmer: Anthony Fung";

        }

        private void Introduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousWindow.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.previousWindow.Visible = true;
            this.Dispose();
        }
    }
}
