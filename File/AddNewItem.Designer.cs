namespace ICT_Project
{
    partial class AddNewItem
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.quanityLabel = new System.Windows.Forms.Label();
            this.quanityTextBox = new System.Windows.Forms.TextBox();
            this.tagLabel = new System.Windows.Forms.Label();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameValidation = new System.Windows.Forms.Label();
            this.lengthValiddation = new System.Windows.Forms.Label();
            this.quanityValiddation = new System.Windows.Forms.Label();
            this.optionalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(39, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Item name";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(99, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 17);
            this.title.TabIndex = 0;
            this.title.Text = "ADD NEW ITEM";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(64, 172);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(39, 84);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(59, 13);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Item length";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(108, 84);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 7;
            // 
            // quanityLabel
            // 
            this.quanityLabel.AutoSize = true;
            this.quanityLabel.Location = new System.Drawing.Point(39, 111);
            this.quanityLabel.Name = "quanityLabel";
            this.quanityLabel.Size = new System.Drawing.Size(66, 13);
            this.quanityLabel.TabIndex = 9;
            this.quanityLabel.Text = "Item Quanity";
            // 
            // quanityTextBox
            // 
            this.quanityTextBox.Location = new System.Drawing.Point(108, 111);
            this.quanityTextBox.Name = "quanityTextBox";
            this.quanityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quanityTextBox.TabIndex = 10;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(39, 139);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(55, 13);
            this.tagLabel.TabIndex = 11;
            this.tagLabel.Text = "Tag Label";
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(108, 137);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagTextBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(154, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameValidation
            // 
            this.nameValidation.AutoSize = true;
            this.nameValidation.ForeColor = System.Drawing.Color.Red;
            this.nameValidation.Location = new System.Drawing.Point(214, 60);
            this.nameValidation.Name = "nameValidation";
            this.nameValidation.Size = new System.Drawing.Size(46, 13);
            this.nameValidation.TabIndex = 14;
            this.nameValidation.Text = "             ";
            // 
            // lengthValiddation
            // 
            this.lengthValiddation.AutoSize = true;
            this.lengthValiddation.ForeColor = System.Drawing.Color.Red;
            this.lengthValiddation.Location = new System.Drawing.Point(216, 87);
            this.lengthValiddation.Name = "lengthValiddation";
            this.lengthValiddation.Size = new System.Drawing.Size(28, 13);
            this.lengthValiddation.TabIndex = 15;
            this.lengthValiddation.Text = "       ";
            // 
            // quanityValiddation
            // 
            this.quanityValiddation.AutoSize = true;
            this.quanityValiddation.BackColor = System.Drawing.SystemColors.Control;
            this.quanityValiddation.ForeColor = System.Drawing.Color.Red;
            this.quanityValiddation.Location = new System.Drawing.Point(216, 118);
            this.quanityValiddation.Name = "quanityValiddation";
            this.quanityValiddation.Size = new System.Drawing.Size(19, 13);
            this.quanityValiddation.TabIndex = 17;
            this.quanityValiddation.Text = "    ";
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.Location = new System.Drawing.Point(216, 144);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(52, 13);
            this.optionalLabel.TabIndex = 18;
            this.optionalLabel.Text = "(Optional)";
            this.optionalLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.optionalLabel);
            this.Controls.Add(this.quanityValiddation);
            this.Controls.Add(this.lengthValiddation);
            this.Controls.Add(this.nameValidation);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.quanityTextBox);
            this.Controls.Add(this.quanityLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.title);
            this.Name = "AddNewItem";
            this.Text = "Add New Item Window";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label quanityLabel;
        private System.Windows.Forms.TextBox quanityTextBox;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameValidation;
        private System.Windows.Forms.Label lengthValiddation;
        private System.Windows.Forms.Label quanityValiddation;
        private System.Windows.Forms.Label optionalLabel;
    }
}