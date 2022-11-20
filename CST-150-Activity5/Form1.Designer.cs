namespace CST_150_Activity5
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
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lowerCaseLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.firstAlphabetLabel = new System.Windows.Forms.Label();
            this.lastAlphabetLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(840, 304);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(237, 79);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload File";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // lowerCaseLabel
            // 
            this.lowerCaseLabel.AutoSize = true;
            this.lowerCaseLabel.Location = new System.Drawing.Point(460, 419);
            this.lowerCaseLabel.Name = "lowerCaseLabel";
            this.lowerCaseLabel.Size = new System.Drawing.Size(121, 25);
            this.lowerCaseLabel.TabIndex = 1;
            this.lowerCaseLabel.Text = "lower case:";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(609, 77);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(707, 139);
            this.title.TabIndex = 2;
            this.title.Text = "Temporary Title";
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Location = new System.Drawing.Point(460, 593);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(152, 25);
            this.longestWordLabel.TabIndex = 3;
            this.longestWordLabel.Text = "Longest Word:";
            // 
            // firstAlphabetLabel
            // 
            this.firstAlphabetLabel.AutoSize = true;
            this.firstAlphabetLabel.Location = new System.Drawing.Point(460, 471);
            this.firstAlphabetLabel.Name = "firstAlphabetLabel";
            this.firstAlphabetLabel.Size = new System.Drawing.Size(136, 25);
            this.firstAlphabetLabel.TabIndex = 4;
            this.firstAlphabetLabel.Text = "first alphabet";
            // 
            // lastAlphabetLabel
            // 
            this.lastAlphabetLabel.AutoSize = true;
            this.lastAlphabetLabel.Location = new System.Drawing.Point(460, 525);
            this.lastAlphabetLabel.Name = "lastAlphabetLabel";
            this.lastAlphabetLabel.Size = new System.Drawing.Size(135, 25);
            this.lastAlphabetLabel.TabIndex = 5;
            this.lastAlphabetLabel.Text = "last alphabet";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Location = new System.Drawing.Point(485, 636);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(127, 25);
            this.mostVowelsLabel.TabIndex = 6;
            this.mostVowelsLabel.Text = "mostVowels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2005, 1095);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.lastAlphabetLabel);
            this.Controls.Add(this.firstAlphabetLabel);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lowerCaseLabel);
            this.Controls.Add(this.uploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lowerCaseLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label firstAlphabetLabel;
        private System.Windows.Forms.Label lastAlphabetLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
    }
}

