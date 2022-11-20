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
            this.button1 = new System.Windows.Forms.Button();
            this.downloadLabel = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.button1.Location = new System.Drawing.Point(785, 851);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Download TextFile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // FileStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(2005, 1095);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label downloadLabel;
    }
}

