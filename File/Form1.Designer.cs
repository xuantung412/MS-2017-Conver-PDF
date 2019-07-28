namespace ICT_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CrossLine6mm = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Density = new System.Windows.Forms.TextBox();
            this.CrossLine = new System.Windows.Forms.TextBox();
            this.SaveLenButton = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.sortLabel = new System.Windows.Forms.Label();
            this.sortFunction = new System.Windows.Forms.ComboBox();
            this.SaveQuanityButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quanityTextBox = new System.Windows.Forms.TextBox();
            this.TotalTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportedItemListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DetailTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SteamThick = new System.Windows.Forms.TextBox();
            this.picture = new AxAcroPDFLib.AxAcroPDF();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrossLine6mm
            // 
            this.CrossLine6mm.AutoSize = true;
            this.CrossLine6mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossLine6mm.Location = new System.Drawing.Point(234, 206);
            this.CrossLine6mm.Name = "CrossLine6mm";
            this.CrossLine6mm.Size = new System.Drawing.Size(111, 17);
            this.CrossLine6mm.TabIndex = 2;
            this.CrossLine6mm.Text = "Cross Line (mm)";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(234, 306);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(143, 17);
            this.Length.TabIndex = 3;
            this.Length.Text = "Welding Length (mm)";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(400, 306);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Density of material";
            // 
            // Density
            // 
            this.Density.Location = new System.Drawing.Point(400, 272);
            this.Density.Name = "Density";
            this.Density.ReadOnly = true;
            this.Density.Size = new System.Drawing.Size(100, 20);
            this.Density.TabIndex = 6;
            this.Density.Text = "7900 kg/m^3";
            // 
            // CrossLine
            // 
            this.CrossLine.Location = new System.Drawing.Point(400, 205);
            this.CrossLine.Name = "CrossLine";
            this.CrossLine.ReadOnly = true;
            this.CrossLine.Size = new System.Drawing.Size(100, 20);
            this.CrossLine.TabIndex = 7;
            this.CrossLine.Text = "6";
            this.CrossLine.TextChanged += new System.EventHandler(this.quanityTextBox_TextChanged);
            // 
            // SaveLenButton
            // 
            this.SaveLenButton.Location = new System.Drawing.Point(506, 304);
            this.SaveLenButton.Name = "SaveLenButton";
            this.SaveLenButton.Size = new System.Drawing.Size(75, 23);
            this.SaveLenButton.TabIndex = 11;
            this.SaveLenButton.Text = "Save";
            this.SaveLenButton.UseVisualStyleBackColor = true;
            this.SaveLenButton.Click += new System.EventHandler(this.SaveLenButton_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Blue;
            this.Time.Location = new System.Drawing.Point(287, 386);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(109, 17);
            this.Time.TabIndex = 12;
            this.Time.Text = "Time(Second)";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(402, 385);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 13;
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.SystemColors.Control;
            this.Detail.Controls.Add(this.deleteButton);
            this.Detail.Controls.Add(this.addNewItemButton);
            this.Detail.Controls.Add(this.sortLabel);
            this.Detail.Controls.Add(this.sortFunction);
            this.Detail.Controls.Add(this.SaveQuanityButton);
            this.Detail.Controls.Add(this.exportButton);
            this.Detail.Controls.Add(this.pictureBox1);
            this.Detail.Controls.Add(this.quanityTextBox);
            this.Detail.Controls.Add(this.TotalTime);
            this.Detail.Controls.Add(this.label5);
            this.Detail.Controls.Add(this.TimeBox);
            this.Detail.Controls.Add(this.TotalTimeLabel);
            this.Detail.Controls.Add(this.ImportButton);
            this.Detail.Controls.Add(this.Time);
            this.Detail.Controls.Add(this.ImportedItemListBox);
            this.Detail.Controls.Add(this.CrossLine);
            this.Detail.Controls.Add(this.button1);
            this.Detail.Controls.Add(this.SaveLenButton);
            this.Detail.Controls.Add(this.DetailTitle);
            this.Detail.Controls.Add(this.CrossLine6mm);
            this.Detail.Controls.Add(this.label3);
            this.Detail.Controls.Add(this.Length);
            this.Detail.Controls.Add(this.SteamThick);
            this.Detail.Controls.Add(this.LengthTextBox);
            this.Detail.Controls.Add(this.label1);
            this.Detail.Controls.Add(this.Density);
            this.Detail.Location = new System.Drawing.Point(0, 19);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(588, 417);
            this.Detail.TabIndex = 14;
            this.Detail.TabStop = false;
            this.Detail.Text = "Detail";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(98, 353);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 23);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Location = new System.Drawing.Point(17, 354);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(75, 20);
            this.addNewItemButton.TabIndex = 27;
            this.addNewItemButton.Text = "Add Item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.Location = new System.Drawing.Point(38, 19);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(51, 13);
            this.sortLabel.TabIndex = 26;
            this.sortLabel.Text = "Sort by:";
            // 
            // sortFunction
            // 
            this.sortFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortFunction.FormattingEnabled = true;
            this.sortFunction.Items.AddRange(new object[] {
            "Item length -Descending",
            "Item length -Ascending",
            "Item time -Descending",
            "Item time -Ascending",
            "Item name(a->z)",
            "File name(a->z)",
            "File name(z->a)"});
            this.sortFunction.Location = new System.Drawing.Point(95, 16);
            this.sortFunction.Name = "sortFunction";
            this.sortFunction.Size = new System.Drawing.Size(106, 21);
            this.sortFunction.TabIndex = 25;
            this.sortFunction.SelectedIndexChanged += new System.EventHandler(this.sortFunction_SelectedIndexChanged);
            // 
            // SaveQuanityButton
            // 
            this.SaveQuanityButton.Location = new System.Drawing.Point(506, 338);
            this.SaveQuanityButton.Name = "SaveQuanityButton";
            this.SaveQuanityButton.Size = new System.Drawing.Size(75, 23);
            this.SaveQuanityButton.TabIndex = 24;
            this.SaveQuanityButton.Text = "Save";
            this.SaveQuanityButton.UseVisualStyleBackColor = true;
            this.SaveQuanityButton.Visible = false;
            this.SaveQuanityButton.Click += new System.EventHandler(this.SaveQuanityButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(98, 380);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(91, 23);
            this.exportButton.TabIndex = 23;
            this.exportButton.Text = "Export to Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT_Project.Properties.Resources.pic;
            this.pictureBox1.Location = new System.Drawing.Point(229, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // quanityTextBox
            // 
            this.quanityTextBox.Location = new System.Drawing.Point(402, 341);
            this.quanityTextBox.Name = "quanityTextBox";
            this.quanityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quanityTextBox.TabIndex = 16;
            this.quanityTextBox.TextChanged += new System.EventHandler(this.quanityTextBox_TextChanged);
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(133, 338);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(13, 13);
            this.TotalTime.TabIndex = 19;
            this.TotalTime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quanity";
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(38, 338);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(89, 13);
            this.TotalTimeLabel.TabIndex = 18;
            this.TotalTimeLabel.Text = "Total Time Label:";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(17, 380);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 16;
            this.ImportButton.Text = "Import File";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportedItemListBox
            // 
            this.ImportedItemListBox.FormattingEnabled = true;
            this.ImportedItemListBox.Location = new System.Drawing.Point(17, 40);
            this.ImportedItemListBox.Name = "ImportedItemListBox";
            this.ImportedItemListBox.Size = new System.Drawing.Size(184, 277);
            this.ImportedItemListBox.TabIndex = 15;
            this.ImportedItemListBox.SelectedIndexChanged += new System.EventHandler(this.ImportedItemListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(506, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DetailTitle
            // 
            this.DetailTitle.AutoSize = true;
            this.DetailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTitle.Location = new System.Drawing.Point(222, 16);
            this.DetailTitle.Name = "DetailTitle";
            this.DetailTitle.Size = new System.Drawing.Size(196, 39);
            this.DetailTitle.TabIndex = 2;
            this.DetailTitle.Text = "Item name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seam thickness (mm)";
            // 
            // SteamThick
            // 
            this.SteamThick.Location = new System.Drawing.Point(400, 238);
            this.SteamThick.Name = "SteamThick";
            this.SteamThick.ReadOnly = true;
            this.SteamThick.Size = new System.Drawing.Size(100, 20);
            this.SteamThick.TabIndex = 4;
            this.SteamThick.Text = "8.5";
            // 
            // picture
            // 
            this.picture.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.picture.AllowDrop = true;
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Enabled = true;
            this.picture.Location = new System.Drawing.Point(594, 19);
            this.picture.Name = "picture";
            this.picture.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("picture.OcxState")));
            this.picture.Size = new System.Drawing.Size(618, 426);
            this.picture.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.picture);
            this.groupBox3.Controls.Add(this.Detail);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1227, 464);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weld";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1227, 464);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CrossLine6mm;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Density;
        private System.Windows.Forms.TextBox CrossLine;
        private System.Windows.Forms.Button SaveLenButton;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.ListBox ImportedItemListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SteamThick;
        private System.Windows.Forms.Label DetailTitle;
        private System.Windows.Forms.Label TotalTime;
        private AxAcroPDFLib.AxAcroPDF picture;
        private System.Windows.Forms.TextBox quanityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button SaveQuanityButton;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox sortFunction;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

