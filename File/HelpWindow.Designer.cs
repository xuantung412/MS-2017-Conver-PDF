namespace ICT_Project
{
    partial class HelpWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.weldCalculationWebsiteButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.youtubeVideo = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.googleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // weldCalculationWebsiteButton
            // 
            this.weldCalculationWebsiteButton.Location = new System.Drawing.Point(59, 34);
            this.weldCalculationWebsiteButton.Name = "weldCalculationWebsiteButton";
            this.weldCalculationWebsiteButton.Size = new System.Drawing.Size(183, 23);
            this.weldCalculationWebsiteButton.TabIndex = 0;
            this.weldCalculationWebsiteButton.Text = "Weld Calculation Website";
            this.weldCalculationWebsiteButton.UseVisualStyleBackColor = true;
            this.weldCalculationWebsiteButton.Click += new System.EventHandler(this.weldCalculationWebsiteButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(275, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(895, 511);
            this.webBrowser.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Youtube- Fillet Welding";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // youtubeVideo
            // 
            this.youtubeVideo.Enabled = true;
            this.youtubeVideo.Location = new System.Drawing.Point(275, 12);
            this.youtubeVideo.Name = "youtubeVideo";
            this.youtubeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtubeVideo.OcxState")));
            this.youtubeVideo.Size = new System.Drawing.Size(895, 511);
            this.youtubeVideo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Youtube- Weld Tutorial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Weld Tips";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // googleButton
            // 
            this.googleButton.Location = new System.Drawing.Point(59, 228);
            this.googleButton.Name = "googleButton";
            this.googleButton.Size = new System.Drawing.Size(183, 23);
            this.googleButton.TabIndex = 6;
            this.googleButton.Text = "Google";
            this.googleButton.UseVisualStyleBackColor = true;
            this.googleButton.Click += new System.EventHandler(this.googleButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(90, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 535);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.googleButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.youtubeVideo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.weldCalculationWebsiteButton);
            this.Name = "HelpWindow";
            this.Text = "HelpWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelpWindow_FormClosing);
            this.Load += new System.EventHandler(this.HelpWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button weldCalculationWebsiteButton;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button button1;
        private AxShockwaveFlashObjects.AxShockwaveFlash youtubeVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button googleButton;
        private System.Windows.Forms.Button backButton;
    }
}