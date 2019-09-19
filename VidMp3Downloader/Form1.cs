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

//https://stackoverflow.com/questions/9679375/run-an-exe-from-c-sharp-code

namespace VidMp3Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (radioButton2.Checked)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (radioButton2.Checked)
                startInfo.Arguments = "-o \"music\\" + textBox2.Text + ".mp3\" -x --audio-format mp3 \"" + textBox1.Text + "\"";
            else
                startInfo.Arguments = "-o \"videos\\" + textBox2.Text + ".%(ext)s\" \"" + textBox1.Text + "\"";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
                MessageBox.Show("Something went wrong with video/mp3 download...");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (radioButton2.Checked)
                startInfo.Arguments = "--extract-audio --audio-format mp3 -i -o \"playlist_music\\%(title)s.%(ext)s\" \"" + textBox3.Text + "\"";
            else
                startInfo.Arguments = " -i -o \"playlist_videos\\%(title)s.%(ext)s\" \"" + textBox3.Text + "\"";

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
