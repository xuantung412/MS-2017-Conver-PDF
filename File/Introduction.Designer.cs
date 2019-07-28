namespace ICT_Project
{
    partial class Introduction
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
            this.introductionLabel = new System.Windows.Forms.Label();
            this.ictProjectTitle = new System.Windows.Forms.Label();
            this.ictProjectText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.organisationText = new System.Windows.Forms.RichTextBox();
            this.studentTitle = new System.Windows.Forms.Label();
            this.studentText = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionLabel.Location = new System.Drawing.Point(315, 9);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(267, 25);
            this.introductionLabel.TabIndex = 0;
            this.introductionLabel.Text = "SA Structural Optimisation";
            // 
            // ictProjectTitle
            // 
            this.ictProjectTitle.AutoSize = true;
            this.ictProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ictProjectTitle.Location = new System.Drawing.Point(109, 66);
            this.ictProjectTitle.Name = "ictProjectTitle";
            this.ictProjectTitle.Size = new System.Drawing.Size(71, 13);
            this.ictProjectTitle.TabIndex = 2;
            this.ictProjectTitle.Text = "ICT Project";
            // 
            // ictProjectText
            // 
            this.ictProjectText.Location = new System.Drawing.Point(12, 82);
            this.ictProjectText.Name = "ictProjectText";
            this.ictProjectText.Size = new System.Drawing.Size(292, 155);
            this.ictProjectText.TabIndex = 3;
            this.ictProjectText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host Organisation";
            // 
            // organisationText
            // 
            this.organisationText.Location = new System.Drawing.Point(320, 82);
            this.organisationText.Name = "organisationText";
            this.organisationText.Size = new System.Drawing.Size(262, 155);
            this.organisationText.TabIndex = 5;
            this.organisationText.Text = "";
            // 
            // studentTitle
            // 
            this.studentTitle.AutoSize = true;
            this.studentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTitle.Location = new System.Drawing.Point(660, 66);
            this.studentTitle.Name = "studentTitle";
            this.studentTitle.Size = new System.Drawing.Size(51, 13);
            this.studentTitle.TabIndex = 6;
            this.studentTitle.Text = "Student";
            // 
            // studentText
            // 
            this.studentText.Location = new System.Drawing.Point(588, 82);
            this.studentText.Name = "studentText";
            this.studentText.Size = new System.Drawing.Size(189, 155);
            this.studentText.TabIndex = 7;
            this.studentText.Text = "";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(421, 243);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Introduction
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 293);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentText);
            this.Controls.Add(this.studentTitle);
            this.Controls.Add(this.organisationText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ictProjectText);
            this.Controls.Add(this.ictProjectTitle);
            this.Controls.Add(this.introductionLabel);
            this.Name = "Introduction";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Introduction_FormClosing);
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label ictProjectTitle;
        private System.Windows.Forms.RichTextBox ictProjectText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox organisationText;
        private System.Windows.Forms.Label studentTitle;
        private System.Windows.Forms.RichTextBox studentText;
        private System.Windows.Forms.Button backButton;
    }
}