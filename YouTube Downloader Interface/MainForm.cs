using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Diagnostics;

namespace YouTube_Downloader_Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DownloadButtonEnabled()
        {
            btnDownload.Enabled = txtDestinationPath.Text != string.Empty && txtURL.Text != string.Empty && txtURL.Text != "https://www.youtube.com" && txtURL.Text != "https://www.youtube.com/";
        }

        private void GetConfiguration()
        {
            if (File.Exists("Config.dat"))
            {
                string JsonConfig = File.ReadLines("Config.dat").First();
                Config? JsonObject = JsonConvert.DeserializeObject<Config>(JsonConfig);
                txtDestinationPath.Text = JsonObject?.DestinationPath;

                switch (JsonObject?.TypeChecked)
                {
                    case "MP4":
                        rbMP4.Checked = true;
                        break;
                    case "MP3":
                        rbMP3.Checked = true;
                        break;
                }
            }
            else
            {
                Config JsonObject = new()
                {
                    DestinationPath = "",
                    TypeChecked = "MP4"
                };

                string JsonConfig = JsonConvert.SerializeObject(JsonObject);
                File.WriteAllLines("Config.dat", new string[] { JsonConfig });
            }
        }

        private void YouTubeWebBrowser_SourceChanged(object? sender, CoreWebView2SourceChangedEventArgs e)
        {
            backNavButton.Enabled = youTubeWebBrowser.CanGoBack;
            forwardNavButton.Enabled = youTubeWebBrowser.CanGoForward;
            txtURL.Text = youTubeWebBrowser.Source.ToString();
        }

        private void YouTubeWebBrowser_ContentLoading(object? sender, CoreWebView2ContentLoadingEventArgs e)
        {
            txtURL.Text = youTubeWebBrowser.Source.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "yt-dlp\\yt-dlp.exe",
                Arguments = $"-U",
                CreateNoWindow = true
            };
            Process? newProcess = Process.Start(startInfo);
            youTubeWebBrowser.SourceChanged += YouTubeWebBrowser_SourceChanged;
            youTubeWebBrowser.ContentLoading += YouTubeWebBrowser_ContentLoading;
            newProcess?.WaitForExit();
            GetConfiguration();
            DownloadButtonEnabled();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config JsonObject = new()
            {
                DestinationPath = txtDestinationPath.Text,
                TypeChecked = rbMP4.Checked ? "MP4" : "MP3"
            };

            string JsonConfig = JsonConvert.SerializeObject(JsonObject);
            File.WriteAllLines("Config.dat", new string[] { JsonConfig });
        }

        private void BtnDestinationPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDestinationPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void TxtDestinationPath_TxtURL_TextChanged(object sender, EventArgs e)
        {
            DownloadButtonEnabled();
        }

        private void TxtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtURL.Text.Contains("https://"))
                {
                    txtURL.Text = "https://" + txtURL.Text;
                }

                Uri uri = new(txtURL.Text);
                youTubeWebBrowser.CoreWebView2.Navigate(uri.ToString());
            }
        }

        private void BackNavButton_Click(object sender, EventArgs e)
        {
            youTubeWebBrowser.GoBack();
        }

        private void ForwardNavButton_Click(object sender, EventArgs e)
        {
            youTubeWebBrowser.GoForward();
        }

        private void RefreshNavButton_Click(object sender, EventArgs e)
        {
            youTubeWebBrowser.Reload();
        }

        private void HomeNavButton_Click(object sender, EventArgs e)
        {
            youTubeWebBrowser.CoreWebView2.Navigate("https://www.youtube.com");
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "yt-dlp\\yt-dlp.exe"
            };

            if (rbMP4.Checked)
            {
                startInfo.Arguments = $"-f bestvideo[ext=mp4]+bestaudio[ext=m4a] {txtURL.Text}";
            }
            else if (rbMP3.Checked)
            {
                startInfo.Arguments = $"-f bestaudio[ext=m4a] -x --audio-format mp3 {txtURL.Text}";
            }

            Process? newProcess = Process.Start(startInfo);
            newProcess?.WaitForExit();

            string srcDir = AppDomain.CurrentDomain.BaseDirectory;
            string destDir = txtDestinationPath.Text;

            List<string> files = new();

            if (Directory.Exists(srcDir) && Directory.Exists(destDir))
            {
                DirectoryInfo dir = new(srcDir);
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Extension == ".mp4" || file.Extension == ".mp3")
                    {
                        files.Add(file.Name);
                        file.MoveTo($@"{destDir}\{file.Name}", true);
                    }
                }
            }
            else
            {
                MessageBox.Show("The destination path is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (files.Count == 0)
            {
                MessageBox.Show("No files where converted", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{string.Join(Environment.NewLine, files)}{Environment.NewLine}{Environment.NewLine}{files.Count} file(s) converted", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
