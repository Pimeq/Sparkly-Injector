using System;
using System.Drawing;
using System.Windows.Forms;

namespace Injector.Dialogs
{
    public partial class Win95 : Form
    {
        public Win95()
        {
            InitializeComponent();
        }

        public static void ShowMsg(string message, string title = "")
        {
            Win95 form = new Win95();

            form.Message.Text = message;
            form.Title.Text = title;

            int msgDif = (form.Message.Width + 20) - form.Width;
            int titleDif = (form.Title.Width + 20) - form.Width;
            if (msgDif > 0 || titleDif > 0)
            {
                int greaterNum = msgDif > titleDif ? msgDif : titleDif;

                form.Width += greaterNum;
                form.TitleBar.Width += greaterNum;
            }

            form.ShowDialog();
        }

        private bool isTopPanelDragged = false;
        private Point offset;
        private Point _normalWindowLocation = Point.Empty;

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
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

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void Win95_Paint(object sender, PaintEventArgs e)
        {
            Pen white = new Pen(Color.White);
            Pen gray = new Pen(Color.Gray);
            Pen black = new Pen(Color.Black);
            Graphics g = e.Graphics;

            g.DrawLine(white, 1, 1, Width - 3, 1);
            g.DrawLine(white, 1, 1, 1, Height - 3);

            g.DrawLine(gray, Width - 2, 1, Width - 2, Height - 3);
            g.DrawLine(gray, 1, Height - 2, Width - 2, Height - 2);

            g.DrawLine(black, Width - 1, 0, Width - 1, Height - 1);
            g.DrawLine(black, 0, Height - 1, Width - 1, Height - 1);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
