using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;
//using System.Reflection;
using System.Diagnostics;
using System.Security;
using System.ComponentModel;

namespace Injector
{
    public partial class MainForm : Form
    {
        private string version = "2.0";
        static private bool ShutUp = false;

        // Do all the stuff we need to do before the program actually does anything
        private static string mainFile = @"https://docs.google.com/document/d/1omcN8Vb0sxRdDJUF98C42-HaQaiRtgS0AZhnOc2Cox8/export?format=txt";
        private static string mainText = null;
        public MainForm()
        {
            InitializeComponent();

            MenuStrip.BackColor = Color.FromArgb(30, 30, 30);
            MenuStrip.ForeColor = Color.FromArgb(50, 100, 255);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            { mainText = new WebClient().DownloadString(mainFile); }
            catch
            {
                MessageBox.Show(
            "The loader couldn't download the info needed.\n" +
            "Check your internet connection", "Error");
                ShutUp = true;
            }

            textBox1.Text = updateInfo();
            updateList();

            if (mainText != null && getNewestVersion() != version)
                MessageBox.Show(
                    $"There's a new update for your loader! Check 'Cade's Sparkly Cheat' server to get it!\n" +
                    $"https://www.Discord.io/SparklyCheat", "New update!");

            cVersion_label.Text += version;
            nVersion_label.Text += getNewestVersion();
        }

        private void updateList()
        {
            Owned.Items.Clear();
            // Get all the DLLs in the Injector's current path
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory);

            foreach (FileInfo file in dir.GetFiles("*.dll"))
            {
                CheatInfo cheat = new CheatInfo();
                cheat.Name = Path.GetFileNameWithoutExtension(file.Name);
                cheat.Path = file.FullName;
                Owned.Items.Add(cheat);
            }

            try
            {
                Downloads.Items.Clear();
                // Get the list of cheats
                string text = new WebClient().DownloadString(mainFile);
                int start = text.IndexOf("Cheats:") + "Cheats:".Length + 1;
                int end = text.IndexOf("Info:");

                string list = text.Substring(start, end - start);
                string[] cheats = list.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < cheats.Length; i++)
                {
                    CheatInfo cheat = new CheatInfo();
                    string[] info = cheats[i].Split(new char[] { ';' }, StringSplitOptions.None);

                    cheat.Name = info[0];
                    cheat.Path = info[1];

                    Downloads.Items.Add(cheat);
                }
            }
            catch (Exception ex)
            {
                if (!ShutUp)
                    MessageBox.Show($"There was a problem downloading the DLL list\n\n{ex.ToString()}", "Error");
            }
        }

        private string updateInfo()
        {
            try
            {
                mainText = new WebClient().DownloadString(mainFile);

                int start = mainText.IndexOf("Info:") + "Info:".Length + 1;
                string info = mainText.Substring(start, mainText.Length - start);
                string output = "";

                for (int i = 0; i < info.Length; i++)
                {
                    if (info[i] == '\r')
                    {
                        if (info.Substring(i, 4) == "\r\n\r\n")
                        {
                            output += Environment.NewLine;
                            i += 3;
                            continue;
                        }
                    }
                    output += info[i];
                }
                return output;
            }
            catch { }

            return null;
        }

        private string getNewestVersion()
        {
            string output = "";
            foreach (char c in mainText)
            {
                if (c >= '.' && c <= '9')
                    output += c;
                else
                    return output;
            }
            return "Error";
        }

        // Outline the window like Windows 10
        Pen p = new Pen(Color.FromArgb(24, 131, 215));
        Rectangle outline;
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            outline = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            g.DrawRectangle(p, outline);
        }
        // Controls to let the user pick the DLL and target process
        private void SelectProc_Click(object sender, EventArgs e)
        {
            ProcessList form = new ProcessList();

            string procName = form.getProc();
            if (procName != null)
                ProcessName.Text = procName;
        }

        // The basic controls of all programs
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(300);
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                NotifyIcon.Visible = false;
            }
        }

        private void TrayInjectExit_Click(object sender, EventArgs e)
        {
            Inject_Click(sender, e);
            Close();
        }

        private void TrayOpen_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        // Inject the DLL into the process and show errors if they occur
        private void Inject_Click(object sender, EventArgs e)
        {
            if (FileList.CheckedItems.Count == 0)
            {
                MessageBox.Show("No files were checked!\nNothing to inject", "Error");
                return;
            }

            DllInjector ayy = DllInjector.GetInstance;
            int failed = 0;
            int attempted = FileList.CheckedItems.Count;
            for (int i = 0; i < attempted; i++)
            {
                string path = (FileList.CheckedItems[i] as CheatInfo).Path;
                switch (ayy.Inject(ProcessName.Text, path))
                {
                    case DllInjectionResult.DllNotFound:
                        MessageBox.Show(
                            $"Specified DLL file not found!\n\n" +
                            $"Attempted to inject:\n" +
                            $"'{path}'", "Error");
                        failed++;
                        break;
                    case DllInjectionResult.GameProcessNotFound:
                        MessageBox.Show($"'{ProcessName.Text}.exe' couldn't be found!", "Error");
                        failed++;
                        return;
                    case DllInjectionResult.InjectionFailed:
                        MessageBox.Show($"Injection failed!\n\n" +
                            $"Attempted to inject:\n" +
                            $"'{path}'", "Error");
                        failed++;
                        break;
                }
            }

            if (MsgAfterInject.Checked)
            {
                Wav.Play(@"C:\Windows\Media\chord.wav");

                if (failed == 0)
                    Dialogs.Win95.ShowMsg(
                        "The injection was successful!\n" +
                        "All DLLs have been injected", "Great news!");
                else
                    Dialogs.Win95.ShowMsg(
                        $"{attempted - failed}/{attempted} " +
                        $"DLLs were successfuly injected", "News of the day");
            }

            if (CloseAfterInject.Checked)
                Close();
        }

        private void updateDlls_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private string cDownloadName = "";
        private string cDownloadDir = "";
        private void DownloadFile_Click(object sender, EventArgs e)
        {
            if (Downloads.SelectedItem == null)
                return;

            CheatInfo selected = Downloads.SelectedItem as CheatInfo;

            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.CurrentDirectory;
            save.Filter = "Dynamic-link library (*.dll)|*.dll";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    WebClient file = new WebClient();
                    file.DownloadFileAsync(new Uri(selected.Path), save.FileName);
                    cDownloadDir = save.FileName;
                    cDownloadName = selected.Name;
                    file.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadComplete);
                    file.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("It seems the injector couldn't download the file\n" +
                        "Most likely just your internet connection :/\n\nError info:\n" +
                        ex.ToString());
                }
            }
        }

        private void downloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            Title.Text = "Sparkly Injector";
            MessageBox.Show($"Finished downloading \"{cDownloadName}\" to \"{Path.GetFileNameWithoutExtension(cDownloadDir)}\"!" +
                $"\nFile path: \"{cDownloadDir}\"", "Download");
        }

        private void downloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            Title.Text = $"Sparkly Injector (Downloading - {e.ProgressPercentage}%)";
        }

        private void QuickInject_Click(object sender, EventArgs e)
        {
            if (Owned.SelectedItem == null)
                return;

            //DLLPath.Text = Environment.CurrentDirectory + "\\" + Owned.SelectedItem.ToString();
            CheatInfo cheat = Owned.SelectedItem as CheatInfo;
            FileList.Items.Add(cheat);
            FileList.SetItemChecked(FileList.Items.Count - 1, true);

            MainTabs.SelectedIndex = 1;
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }

        // Making a custom toolbar that can be dragged
        private bool isTopPanelDragged = false;
        private Point offset;
        private Point _normalWindowLocation = Point.Empty;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Browse = new OpenFileDialog()
            {
                Multiselect = true,
                Title = "Select a cheat",
                Filter =
                "Dynamic Linked Library (*.dll)|*.DLL|" +
                "All files (*.*)|*.*"
            };

            bool sameFileMessage = false;
            if (Browse.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in Browse.FileNames)
                {
                    try
                    {
                        bool sameFile = false;
                        foreach (CheatInfo current in FileList.Items)
                            if (file == current.Path)
                            {
                                sameFile = true;
                                sameFileMessage = true;
                            }
                        if (sameFile) continue;

                        CheatInfo cheat = new CheatInfo();
                        cheat.Name = Path.GetFileNameWithoutExtension(file);
                        cheat.Path = file;

                        FileList.Items.Add(cheat);
                        FileList.SetItemChecked(FileList.Items.Count - 1, true);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n" +
                            "Most likely the injector can't read/write to the directory.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                }

                if (sameFileMessage)
                    MessageBox.Show("One more files you selected are already in the injector", "Error");
            }
        }

        private void AddF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browse = new FolderBrowserDialog();

            bool sameFileMessage = false;
            if (Browse.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(Browse.SelectedPath);
                foreach (FileInfo file in dir.GetFiles("*.dll"))
                {
                    try
                    {
                        bool sameFile = false;
                        foreach (CheatInfo current in FileList.Items)
                            if (file.DirectoryName == current.Path)
                            {
                                sameFileMessage = true;
                                sameFile = true;
                            }
                        if (sameFile) continue;

                        CheatInfo cheat = new CheatInfo();
                        cheat.Name = file.Name;
                        cheat.Path = file.FullName;

                        FileList.Items.Add(cheat);
                        FileList.SetItemChecked(FileList.Items.Count - 1, true);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n" +
                            "Most likely the injector can't read/write to the directory.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                }

                if (sameFileMessage)
                    MessageBox.Show("One more files you selected are already in the injector", "Error");
            }
        }

        private void RemoveFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileList.Items.RemoveAt(FileList.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(
                    "You didn't select anything!!\n\n" +
                    "This is why it's good to baby-proof programs.\n" +
                    "If I didn't, then you'd make the injector crash\n\n" +
                    ">:^(",
                    "Error"
                    );
            }
        }

        private void Uncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileList.Items.Count; i++)
                FileList.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileList.Items.Count; i++)
                FileList.SetItemCheckState(i, CheckState.Checked);
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveFile.Visible = FileList.Items.Count > 0? true : false;
        }

        private void ProcessName_DoubleClick(object sender, EventArgs e)
        {
            ProcessName.SelectAll();
        }

        private string filterNewlines(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
                if (i != '\n' && i != '\r')
                    output += input[i];
            return output;
        }

        private int spacePressed = 0;
        private void ProcessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                spacePressed++;
                System.Media.SystemSounds.Exclamation.Play();
                e.Handled = true;

                if (spacePressed == 10)
                {
                    Wav.Play(@"C:\Windows\Media\chord.wav");
                    Dialogs.Win95.ShowMsg("Stop pressing space!!!", "Quit it!");
                }
            }
        }

        private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(DiscordLink.Text);
        }
    }
}
