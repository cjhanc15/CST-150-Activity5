namespace CST_150_Activity5
{
    partial class FileStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileStatsForm));
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.title = new System.Windows.Forms.Label();
            this.fileStats = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.userFileName = new System.Windows.Forms.TextBox();
            this.fileFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uploadButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.uploadButton.Location = new System.Drawing.Point(1253, 227);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(237, 58);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload File";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(2018, 139);
            this.title.TabIndex = 2;
            this.title.Text = "FileStats";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileStats
            // 
            this.fileStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.fileStats.Font = new System.Drawing.Font("Candara Light", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.fileStats.Location = new System.Drawing.Point(469, 300);
            this.fileStats.Multiline = true;
            this.fileStats.Name = "fileStats";
            this.fileStats.Size = new System.Drawing.Size(1021, 513);
            this.fileStats.TabIndex = 7;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.downloadButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Bold);
            this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.downloadButton.Location = new System.Drawing.Point(1142, 844);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(348, 72);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.Text = "Download TextFile";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.downloadLabel.Location = new System.Drawing.Point(780, 923);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(18, 25);
            this.downloadLabel.TabIndex = 9;
            this.downloadLabel.Text = " ";
            // 
            // userFileName
            // 
            this.userFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.userFileName.Font = new System.Drawing.Font("Candara Light", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.userFileName.Location = new System.Drawing.Point(469, 844);
            this.userFileName.Name = "userFileName";
            this.userFileName.Size = new System.Drawing.Size(557, 72);
            this.userFileName.TabIndex = 10;
            this.userFileName.Text = "fileStats";
            this.userFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileFormat
            // 
            this.fileFormat.AutoSize = true;
            this.fileFormat.Font = new System.Drawing.Font("Candara Light", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.fileFormat.Location = new System.Drawing.Point(1032, 852);
            this.fileFormat.Name = "fileFormat";
            this.fileFormat.Size = new System.Drawing.Size(104, 64);
            this.fileFormat.TabIndex = 11;
            this.fileFormat.Text = ".txt";
            // 
            // FileStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(2005, 1095);
            this.Controls.Add(this.fileFormat);
            this.Controls.Add(this.userFileName);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.fileStats);
            this.Controls.Add(this.title);
            this.Controls.Add(this.uploadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileStatsForm";
            this.Text = "FileStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox fileStats;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.TextBox userFileName;
        private System.Windows.Forms.Label fileFormat;
    }
}

