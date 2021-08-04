using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

using getsumChecksums.Properties;

namespace getsumChecksums
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblRootPath.Text = Settings.Default.lastPath;
                cmbHashType.Text = Settings.Default.hashType;
                ListFiles(Settings.Default.lastPath);
            }
            catch { }

            if (cmbHashType.Text == "")
                cmbHashType.Text = "MD5";
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            folderBrowser.SelectedPath = lblRootPath.Text;
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblRootPath.Text = folderBrowser.SelectedPath.ToString();
                lstFiles.Items.Clear();
                ListFiles(folderBrowser.SelectedPath.ToString());
            }

            Settings.Default.lastPath = lblRootPath.Text;
            Settings.Default.hashType = cmbHashType.Text;
            Settings.Default.Save();
        }

        private void cmdRescan_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            ListFiles(lblRootPath.Text);
        }

        private void lstFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstFiles.SelectedItems.Count != 0)
                Clipboard.SetText(lstFiles.SelectedItems[0].SubItems[2].Text);
        }

        private void cmbHashType_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.hashType = cmbHashType.Text;
            Settings.Default.Save();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
        }

        #region Custom Functions
        /// <summary>
        /// Get the MD5 checksum for a given file.
        /// </summary>
        public static string md5Hash(string filename)
        {
            if (File.Exists(filename))
                using (var md5 = MD5.Create())
                    using (var stream = File.OpenRead(filename))
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
            else
                return null;
        }

        /// <summary>
        /// Get the SHA1 checksum for a given file.
        /// </summary>
        public static string sha1Hash(string filename)
        {
            if (File.Exists(filename))
                using (var sha1 = SHA1.Create())
                    using (var stream = File.OpenRead(filename))
                        return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", "").ToLower();
            else
                return null;
        }

        /// <summary>
        /// Recrusivly parse a directory for all files.
        /// Place the file name, md5/sha1 checksum, and sub directory (if applicible) in a ListView (lstFiles).
        /// </summary>
        public void ListFiles(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfo = directoryInfo.GetFiles();
                DirectoryInfo[] subdirectoryInfo = directoryInfo.GetDirectories();
                string directoryName;

                foreach (DirectoryInfo subDirectory in subdirectoryInfo)
                    ListFiles(subDirectory.FullName);

                foreach (FileInfo file in fileInfo)
                {
                    directoryName = file.DirectoryName.Replace(lblRootPath.Text + "\\", "");

                    if (directoryName == lblRootPath.Text)
                        directoryName = "";

                    if (Settings.Default.hashType == "MD5")
                    {
                        lstFiles.Items.Add(new ListViewItem(new string[] { file.Name, directoryName, md5Hash(file.FullName) }));
                    }

                    if (md5Hash(file.FullName) == "c0d2f76ad75c6d343e5259b4bcebca46" || md5Hash(file.FullName) == "0e7e4cf93beb062c37b112f125177d27")
                    {
                        String caption = "Malware App found";
                        String message = "File  " + "'" + file + "'" + "  is detected as malware. ";

                        MessageBoxButtons button = MessageBoxButtons.OKCancel;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, button);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }

                    
                        
                     else if (Settings.Default.hashType == "SHA1")
                    {
                        lstFiles.Items.Add(new ListViewItem(new string[] { file.Name, directoryName, sha1Hash(file.FullName) }));
                    }

                    if (md5Hash(file.FullName) == "c0d2f76ad75c6d343e5259b4bcebca46" || md5Hash(file.FullName) == "0e7e4cf93beb062c37b112f125177d27")
                    {
                        String caption = "File is deleted";
                        String message = "File  " + "'" + file + "'" + "  is deleted ";

                        MessageBoxButtons button = MessageBoxButtons.OKCancel;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, button);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    
                    
                  }

                if (File.Exists(@"C:\Users\jonx\Desktop\Ackcmd\AckCmdC.exe"))
                {
                    File.Delete(@"C:\Users\jonx\Desktop\Ackcmd\AckCmdC.exe");
                }

            }
        }
        #endregion
    }
}
