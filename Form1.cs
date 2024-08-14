using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace IS
{
    public partial class IS : Form
    {
        public IS()
        {
            InitializeComponent();
        }
        public string downloadpath = "download";
        public int index;

        private void button1_Click(object sender, EventArgs e)
        {
            index = listBox2.SelectedIndex;
            switch (index)
            {
                case 0: WebClient client = new WebClient(); client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(pb); client.DownloadFileCompleted += commit; client.DownloadFileAsync(new Uri("https://dl.bandisoft.com/bandizip.std/BANDIZIP-SETUP-STD-X64.EXE?12"), @"download\bs.exe"); break;
                case 1: WebClient client2 = new WebClient(); client2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(pb); client2.DownloadFileCompleted += commit; client2.DownloadFileAsync(new Uri("https://cstore-pub-cos-seewo-report-tx.seewo.com/seewo-report_uwiwvnmohhulnhlwhnqykloxquphihhh?sign=q-sign-algorithm%3Dsha1%26q-ak%3DAKIDJUXMxJRLzPaeMp20jDSTFl23pLcdPwDF%26q-sign-time%3D1722821977%3B2038181977%26q-key-time%3D1722821977%3B2038181977%26q-header-list%3Dhost%26q-url-param-list%3Dresponse-content-disposition%26q-signature%3D33dfc17d2021be9a55a7eb1cfcff25fde0cd5706&response-content-disposition=attachment%3Bfilename%3D%22EasiNoteSetup_5.2.4.8294_seewo.exe%22%3Bfilename%2A%3Dutf-8%27%27EasiNoteSetup_5.2.4.8294_seewo.exe"), @"download\es.exe"); break;
                case 2: WebClient client3 = new WebClient(); client3.DownloadProgressChanged += new DownloadProgressChangedEventHandler(pb); client3.DownloadFileCompleted += commit; client3.DownloadFileAsync(new Uri("https://c2rsetup.officeapps.live.com/c2r/download.aspx?ProductreleaseID=ProPlus2021Retail&language=zh-CN&platform=x64&TaxRegion=PR&Source=O15PKC&version=O16GA"), @"download\os.exe"); break;
                case 3: WebClient client4 = new WebClient(); client4.DownloadProgressChanged += new DownloadProgressChangedEventHandler(pb); client4.DownloadFileCompleted += commit; client4.DownloadFileAsync(new Uri("https://t1.daumcdn.net/potplayer/PotPlayer/Version/Latest/PotPlayerSetup64.exe"), @"download\ps.exe"); break;
                case 4: WebClient client5 = new WebClient(); client5.DownloadProgressChanged += new DownloadProgressChangedEventHandler(pb); client5.DownloadFileCompleted += commit; client5.DownloadFileAsync(new Uri("https://dldir1v6.qq.com/weixin/Windows/WeChatSetup.exe"), @"download\ws.exe"); break;

            }
        }

        private void IS_Load(object sender, EventArgs e)
        {
            label1.Text = "0%";
            try
            {
                if (Directory.Exists(downloadpath))
                {
                }
                else
                {
                    Directory.CreateDirectory(downloadpath);
                }
            }
            catch(Exception) {
                MessageBox.Show("Error!", "IS", 0, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void pb(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive;
            progressBar1.Value = (int)e.BytesReceived;
            label1.Text = e.ProgressPercentage + "%";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "0%";
        }
        private void commit(object sender,AsyncCompletedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            string fn;
            switch (index)
            {
                case 0: fn = @"download\bs.exe"; p.StartInfo.FileName = fn; p.Start(); this.Hide(); p.WaitForExit(); p.Close(); this.Show(); progressBar1.Value = 0; label1.Text = "0%"; break;
                case 1: fn = @"download\es.exe"; p.StartInfo.FileName = fn; p.Start(); this.Hide(); p.WaitForExit(); p.Close(); this.Show(); progressBar1.Value = 0; label1.Text = "0%"; break;
                case 2: fn = @"download\os.exe"; p.StartInfo.FileName = fn; p.Start(); this.Hide(); p.WaitForExit(); p.Close(); this.Show(); progressBar1.Value = 0; label1.Text = "0%"; break;
                case 3: fn = @"download\ps.exe"; p.StartInfo.FileName = fn; p.Start(); this.Hide(); p.WaitForExit(); p.Close(); this.Show(); progressBar1.Value = 0; label1.Text = "0%"; break;
                case 4: fn = @"download\ws.exe"; p.StartInfo.FileName = fn; p.Start(); this.Hide(); p.WaitForExit(); p.Close(); this.Show(); progressBar1.Value = 0; label1.Text = "0%"; break;
                
            }
            
        }
    }
}
