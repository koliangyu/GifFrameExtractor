namespace GifFrameExtractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLocalFilePath = new TextBox();
            btnSelectLocalFile = new Button();
            txtFileUrl = new TextBox();
            btnDownloadFile = new Button();
            txtOutputFolderPath = new TextBox();
            btnSelectOutputFolder = new Button();
            SuspendLayout();
            // 
            // txtLocalFilePath
            // 
            txtLocalFilePath.Location = new Point(35, 52);
            txtLocalFilePath.Name = "txtLocalFilePath";
            txtLocalFilePath.Size = new Size(526, 27);
            txtLocalFilePath.TabIndex = 0;
            // 
            // btnSelectLocalFile
            // 
            btnSelectLocalFile.Location = new Point(567, 52);
            btnSelectLocalFile.Name = "btnSelectLocalFile";
            btnSelectLocalFile.Size = new Size(147, 29);
            btnSelectLocalFile.TabIndex = 1;
            btnSelectLocalFile.Text = "Select Local File";
            btnSelectLocalFile.UseVisualStyleBackColor = true;
            btnSelectLocalFile.Click += btnSelectLocalFile_Click;
            // 
            // txtFileUrl
            // 
            txtFileUrl.Location = new Point(35, 125);
            txtFileUrl.Name = "txtFileUrl";
            txtFileUrl.PlaceholderText = "Please enter the URL";
            txtFileUrl.Size = new Size(526, 27);
            txtFileUrl.TabIndex = 2;
            // 
            // btnDownloadFile
            // 
            btnDownloadFile.Location = new Point(567, 125);
            btnDownloadFile.Name = "btnDownloadFile";
            btnDownloadFile.Size = new Size(147, 29);
            btnDownloadFile.TabIndex = 3;
            btnDownloadFile.Text = "Download File";
            btnDownloadFile.UseVisualStyleBackColor = true;
            btnDownloadFile.Click += btnDownloadFile_Click;
            // 
            // txtOutputFolderPath
            // 
            txtOutputFolderPath.Location = new Point(35, 201);
            txtOutputFolderPath.Name = "txtOutputFolderPath";
            txtOutputFolderPath.Size = new Size(526, 27);
            txtOutputFolderPath.TabIndex = 4;
            // 
            // btnSelectOutputFolder
            // 
            btnSelectOutputFolder.Location = new Point(567, 199);
            btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            btnSelectOutputFolder.Size = new Size(173, 29);
            btnSelectOutputFolder.TabIndex = 5;
            btnSelectOutputFolder.Text = "Select Output Folder";
            btnSelectOutputFolder.UseVisualStyleBackColor = true;
            btnSelectOutputFolder.Click += btnSelectOutputFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectOutputFolder);
            Controls.Add(txtOutputFolderPath);
            Controls.Add(btnDownloadFile);
            Controls.Add(txtFileUrl);
            Controls.Add(btnSelectLocalFile);
            Controls.Add(txtLocalFilePath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocalFilePath;
        private Button btnSelectLocalFile;
        private TextBox txtFileUrl;
        private Button btnDownloadFile;
        private TextBox txtOutputFolderPath;
        private Button btnSelectOutputFolder;
    }
}