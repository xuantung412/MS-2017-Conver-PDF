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
    public partial class HelpWindow : Form
    {
        Begin previousWindow;
        public HelpWindow(Begin window)
        {
            InitializeComponent();
            this.Visible = true;
            webBrowser.Visible = false;
            youtubeVideo.Visible = false;
            this.previousWindow = window;
        }

        private void weldCalculationWebsiteButton_Click(object sender, EventArgs e)
        {
            youtubeVideo.Visible = false ;
            webBrowser.Visible = true;
            webBrowser.Navigate("http://boehler-welding-service.com/voestalpine/calculator/eng/");
        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = false;
            youtubeVideo.Visible = true;
            youtubeVideo.Movie = "https://www.youtube.com/v/DM0vr3VpO10";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = false;
            youtubeVideo.Visible = true;
            youtubeVideo.Movie = "https://www.youtube.com/v/ha_9n5Xbklw";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            youtubeVideo.Visible = false;
            webBrowser.Visible = true;
            webBrowser.Navigate("https://www.millerwelds.com/resources/article-library/five-steps-to-improving-your-stick-welding-technique");
        }

        private void HelpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousWindow.Visible = true;
        }

        private void googleButton_Click(object sender, EventArgs e)
        {
            youtubeVideo.Visible = false;
            webBrowser.Visible = true;
            webBrowser.Navigate("https://www.google.com.au/");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.previousWindow.Visible = true;
            this.Dispose();
        }
    }
}
