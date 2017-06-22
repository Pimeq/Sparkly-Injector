using System;
//using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Injector
{
    public partial class ProcessList : Form
    {
        //private DataTable list = new DataTable();
        //private Process[] procArray;

        public ProcessList()
        {
            InitializeComponent();

            //procArray = Process.GetProcesses();

            //list.Columns.Add("Process", typeof(string));
            //foreach (Process current in procArray)
            foreach (Process current in Process.GetProcesses())
            {
                ProcessInfo info = new ProcessInfo();
                info.process = current;
                ProcessDisplay.Items.Add(info);
                //list.Rows.Add(info);
            }
            //ProcessDisplay.DataSource = list;
            //ProcessDisplay.DisplayMember = "Process";
        }

        private Pen p = new Pen(Color.FromArgb(24, 131, 215));
        private Rectangle outline;
        private void ProcessList_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            outline = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            g.DrawRectangle(p, outline);
        }

        private string SelectedProc;
        private void ProcessDisplay_DoubleClick(object sender, EventArgs e)
        {
            //SelectedProc = procArray[ProcessDisplay.SelectedIndex].ProcessName;
            SelectedProc = (ProcessDisplay.SelectedItem as ProcessInfo).process.ProcessName;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string getProc()
        {
            ShowDialog();

            if (DialogResult == DialogResult.OK)
                return SelectedProc;
            return null;
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (SearchBar.Text[SearchBar.Text.Length - 1] == '\'')
                {
                    string str = SearchBar.Text.Substring(0, SearchBar.Text.Length);
                    SearchBar.Text = str;
                    return;
                }
            }
            catch { }
            string safeString = "";
            foreach (char ch in SearchBar.Text)
            {
                if (ch == '\'')
                    continue;
                else if (ch == '_' || ch == '%'|| ch == '[' || ch == ']')
                {
                    safeString += $"[{ch}]";
                    continue;
                }
                safeString += ch;
            }

            DataView dvList = list.DefaultView;
            dvList.RowFilter = $"Process LIKE '%{safeString}%'";*/
        }

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

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }
    }
}
