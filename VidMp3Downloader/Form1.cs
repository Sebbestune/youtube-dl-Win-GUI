using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

//https://stackoverflow.com/questions/9679375/run-an-exe-from-c-sharp-code

namespace VidMp3Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string dependecyyoutube_dl = @"youtube-dl.exe";
            string dependecyffmpeg = @"ffmpeg.exe";
            string dependecyffprobe = @"ffprobe.exe";
            Console.WriteLine("Downloading dependency files");
            if (!File.Exists(dependecyyoutube_dl)) {

                string message = "youtube-dl was not found in this folder. Proceed with downloading it now?";
                string title = "Downloading dependencies";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/Sebbestune/youtube-dl-Win-GUI/blob/master/VidMp3Downloader/bin/Release/youtube-dl.exe?raw=true", "youtube-dl.exe");
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            if (!File.Exists(dependecyffmpeg))
            {
                string message = "ffmpeg was not found in this folder. Proceed with downloading it now?";
                string title = "Downloading dependencies";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/Sebbestune/youtube-dl-Win-GUI/blob/master/VidMp3Downloader/bin/Release/ffmpeg.exe?raw=true", "ffmpeg.exe");
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }  
            }
            if (!File.Exists(dependecyffprobe))
            {
                string message = "ffprobe was not found in this folder. Proceed with downloading it now?";
                string title = "Downloading dependencies";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/Sebbestune/youtube-dl-Win-GUI/blob/master/VidMp3Downloader/bin/Release/ffprobe.exe?raw=true", "ffprobe.exe");
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-U";
            
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                MessageBox.Show("Could not update youtube-dl.exe.");
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (mp3RadioButton.Checked)
                startInfo.Arguments = "--extract-audio --audio-format mp3 -i -o \"music\\%(title)s.%(ext)s\" \"" + urlTextBox.Text + "\"";
            else
                startInfo.Arguments = " -i -o \"videos\\%(title)s.%(ext)s\" \"" + urlTextBox.Text + "\"";

            //youtube-dl --extract-audio --audio-format mp3 -o "%(title)s.%(ext)s" <url to playlist>

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong with the playlist download...");
            }
        }
    }
}
