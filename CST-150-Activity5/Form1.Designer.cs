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
            this.title = new System.Windows.Forms.Label();
            this.fileStats = new System.Windows.Forms.TextBox();
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
            // fileStats
            // 
            this.fileStats.Font = new System.Drawing.Font("Cambria", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileStats.Location = new System.Drawing.Point(456, 389);
            this.fileStats.Multiline = true;
            this.fileStats.Name = "fileStats";
            this.fileStats.Size = new System.Drawing.Size(1021, 513);
            this.fileStats.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2005, 1095);
            this.Controls.Add(this.fileStats);
            this.Controls.Add(this.title);
            this.Controls.Add(this.uploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox fileStats;
    }
}

