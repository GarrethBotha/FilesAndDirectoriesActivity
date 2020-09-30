namespace Activity_4._1._1
{
    partial class FileViewerForm
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
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.rtbFolderViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(282, 57);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(181, 32);
            this.btnOpenFolderBrowser.TabIndex = 0;
            this.btnOpenFolderBrowser.Text = "Open Folder Browser";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // rtbFolderViewer
            // 
            this.rtbFolderViewer.Location = new System.Drawing.Point(118, 292);
            this.rtbFolderViewer.Name = "rtbFolderViewer";
            this.rtbFolderViewer.Size = new System.Drawing.Size(550, 96);
            this.rtbFolderViewer.TabIndex = 1;
            this.rtbFolderViewer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFolderViewer);
            this.Controls.Add(this.btnOpenFolderBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.RichTextBox rtbFolderViewer;
    }
}

