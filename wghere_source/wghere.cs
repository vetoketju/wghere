using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpDownloader
{
    public partial class wghere : Form
    {
        public string url = "";
        public string filename = "_wghereDownloaderFile";
        public string outputfolder = "";
        string[] args;

        public wghere(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pathDownload = Path.Combine(pathUser, "Downloads");

            if (args.Length < 1 || !Directory.Exists(args[0]))
            {
                DialogResult res = MessageBox.Show("No output folder specified. Downloading to: "+pathDownload, "Warning", MessageBoxButtons.OKCancel);
                if (res != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                outputfolder = pathDownload;
            }
            else outputfolder = args[0];

            if (!outputfolder.EndsWith("/"))
                outputfolder += "/";

            System.Diagnostics.Debug.WriteLine(pathDownload);

            if (urlBox.Text.Trim() != "" && urlBox.Text.Trim().StartsWith("http://"))
            {
                url = urlBox.Text.Trim();
                filename = url.Substring(url.LastIndexOf("/")+1);
          
                if (File.Exists(outputfolder + filename))
                    filename = string.Format("{0:yyyy-MM-dd_HH-mm-ss}", DateTime.Now) + filename;

                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(new Uri(url),outputfolder+filename);
                }
                catch (Exception er)
                {
                    DialogResult res = MessageBox.Show(er.ToString(), "Error occured:", MessageBoxButtons.OK);
                    Application.Exit();
                    return;
                }
            }else  MessageBox.Show("Bad url");
         

        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Application.Exit();
        }
    }
}
