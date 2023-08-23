namespace HoroscopeReading
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
            this.verifyUsernameButton = new System.Windows.Forms.Button();
            this.verifyNameLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.invalidNameLabel = new System.Windows.Forms.Label();
            this.getReadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verifyUsernameButton
            // 
            this.verifyUsernameButton.Location = new System.Drawing.Point(167, 174);
            this.verifyUsernameButton.Name = "verifyUsernameButton";
            this.verifyUsernameButton.Size = new System.Drawing.Size(75, 23);
            this.verifyUsernameButton.TabIndex = 0;
            this.verifyUsernameButton.Text = "Verify";
            this.verifyUsernameButton.UseVisualStyleBackColor = true;
            this.verifyUsernameButton.Click += new System.EventHandler(this.verifyUsernameButton_Click);
            // 
            // verifyNameLabel
            // 
            this.verifyNameLabel.AutoSize = true;
            this.verifyNameLabel.Location = new System.Drawing.Point(48, 216);
            this.verifyNameLabel.Name = "verifyNameLabel";
            this.verifyNameLabel.Size = new System.Drawing.Size(0, 13);
            this.verifyNameLabel.TabIndex = 1;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(51, 253);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(167, 253);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(48, 83);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(88, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter Your Name";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(142, 83);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // invalidNameLabel
            // 
            this.invalidNameLabel.AutoSize = true;
            this.invalidNameLabel.Location = new System.Drawing.Point(48, 118);
            this.invalidNameLabel.Name = "invalidNameLabel";
            this.invalidNameLabel.Size = new System.Drawing.Size(0, 13);
            this.invalidNameLabel.TabIndex = 1;
            // 
            // getReadingLabel
            // 
            this.getReadingLabel.AutoSize = true;
            this.getReadingLabel.Location = new System.Drawing.Point(48, 290);
            this.getReadingLabel.Name = "getReadingLabel";
            this.getReadingLabel.Size = new System.Drawing.Size(0, 13);
            this.getReadingLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getReadingLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.invalidNameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.verifyNameLabel);
            this.Controls.Add(this.verifyUsernameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verifyUsernameButton;
        private System.Windows.Forms.Label verifyNameLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label invalidNameLabel;
        private System.Windows.Forms.Label getReadingLabel;
    }
}

