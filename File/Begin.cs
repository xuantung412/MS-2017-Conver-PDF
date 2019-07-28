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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }


        private void introductionButton_Click(object sender, EventArgs e)
        {
            Introduction intro = new Introduction(this);
            this.Visible = false;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1(this);
            this.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpWindow a = new HelpWindow(this);
            this.Visible = false;

        }

    }
}
