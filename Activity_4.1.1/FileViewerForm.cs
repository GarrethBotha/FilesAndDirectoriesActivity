using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_4._1._1
{
    public partial class FileViewerForm : Form
    {
        private System.Windows.Forms.FolderBrowserDialog fbd1;

        public FileViewerForm()
        {
            InitializeComponent();
        }

        private void btnOpenFolderBrowser_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = folderDlg.SelectedPath;
                rtbFolderViewer.Text = folderPath;
            }

            FileStream outputFile = new FileStream("myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outputFile);

            writer.WriteLine(folderPath);
            writer.Close();
            outputFile.Close();
        }
    }
}
