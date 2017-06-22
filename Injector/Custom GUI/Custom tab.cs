using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Custom_GUI
{
    public class TabControl : System.Windows.Forms.TabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public TabControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Interop

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr HWND;
            public uint idFrom;
            public int code;
            public override String ToString()
            {
                return String.Format("Hwnd: {0}, ControlID: {1}, Code: {2}", HWND, idFrom, code);
            }
        }

        private const int TCN_FIRST = 0 - 550;
        private const int TCN_SELCHANGING = (TCN_FIRST - 2);

        private const int WM_USER = 0x400;
        private const int WM_NOTIFY = 0x4E;
        private const int WM_REFLECT = WM_USER + 0x1C00;

        #endregion

        #region BackColor Manipulation

        //As well as exposing the property to the Designer we want it to behave just like any other 
        //controls BackColor property so we need some clever manipulation.

        private Color m_Backcolor = Color.Empty;
        [Browsable(true), Description("The background color used to display text and graphics in a control.")]
        public override Color BackColor
        {
            get
            {
                if (m_Backcolor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Control.DefaultBackColor;
                    else
                        return Parent.BackColor;
                }
                return m_Backcolor;
            }
            set
            {
                if (m_Backcolor.Equals(value)) return;
                m_Backcolor = value;
                Invalidate();
                //Let the Tabpages know that the backcolor has changed.
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }
        public bool ShouldSerializeBackColor()
        {
            return !m_Backcolor.Equals(Color.Empty);
        }
        public override void ResetBackColor()
        {
            m_Backcolor = Color.Empty;
            Invalidate();
        }

        #endregion

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            Invalidate();
        }

        [Category("Appearance")]
        [Description("Displays a border around the tabs")]
        public bool TabBorder { get; set; } = false;

        [Category("Appearance")]
        [Description("Displays a border around the pages under the tabs")]
        public bool PageBorder { get; set; } = true;

        [Category("Appearance")]
        [Description("Sets the color of the tab border")]
        public Color TabBorderColor { get; set; } = Color.FromArgb(150, 150, 150);

        [Category("Appearance")]
        [Description("Sets the color of the tab page border")]
        public Color PageBorderColor { get; set; } = Color.FromArgb(150, 150, 150);

        [Category("Appearance")]
        [Description("Sets the color of the tab page background")]
        public Color PageBackColor { get; set; } = Color.FromArgb(30, 30, 30);

        [Category("Appearance")]
        [Description("Sets the color of a tab when it's open")]
        public Color CurrentTab { get; set; } = Color.FromArgb(0, 122, 204);

        [Category("Appearance")]
        [Description("Sets the color of a tab when it's closed")]
        public Color ClosedTab { get; set; } = Color.FromArgb(30, 30, 30);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            Rectangle r = ClientRectangle;
            if (TabCount <= 0) return;

            //Draw a custom background for Transparent TabPages
            r = SelectedTab.Bounds;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //Draw a border around TabPage
            r.Inflate(3, 3);
            TabPage tp = TabPages[SelectedIndex];

            // Draw the line running under the tabs
            Rectangle Tabline = new Rectangle(GetTabRect(0).X, r.Y + 1, r.Width, 2);
            e.Graphics.FillRectangle(new SolidBrush(CurrentTab), Tabline);
            //ControlPaint.DrawBorder(e.Graphics, r, BorderColor, ButtonBorderStyle.Solid);

            //Draw the Tabs
            SolidBrush PaintBrush = new SolidBrush(tp.BackColor);
            for (int index = 0; index < TabCount; index++)
            {
                tp = TabPages[index];
                r = GetTabRect(index);

                tp.BackColor = PageBackColor;

                if (index == SelectedIndex)
                    e.Graphics.FillRectangle(new SolidBrush(CurrentTab), r);
                else
                    e.Graphics.FillRectangle(new SolidBrush(ClosedTab), r);

                if (TabBorder)
                    ControlPaint.DrawBorder(e.Graphics, r, TabBorderColor, ButtonBorderStyle.Solid);
                if (PageBorder)
                {
                    Rectangle b = base.DisplayRectangle;
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(PageBorderColor)), b.X - 1, b.Y - 1, b.Width + 1, b.Height + 1);
                }

                PaintBrush.Color = tp.ForeColor;

                //Set up rotation for left and right aligned tabs
                if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
                {
                    float RotateAngle = 90;
                    if (Alignment == TabAlignment.Left) RotateAngle = 270;
                    PointF cp = new PointF(r.Left + (r.Width >> 1), r.Top + (r.Height >> 1));
                    e.Graphics.TranslateTransform(cp.X, cp.Y);
                    e.Graphics.RotateTransform(RotateAngle);
                    r = new Rectangle(-(r.Height >> 1), -(r.Width >> 1), r.Height, r.Width);
                }
                //Draw the Tab Text
                if (tp.Enabled)
                    e.Graphics.DrawString(tp.Text, Font, PaintBrush, (RectangleF)r, sf);
                else
                    ControlPaint.DrawStringDisabled(e.Graphics, tp.Text, Font, tp.BackColor, (RectangleF)r, sf);

                e.Graphics.ResetTransform();
            }
            PaintBrush.Dispose();
        }

        [Description("Occurs as a tab is being changed.")]
        public event SelectedTabPageChangeEventHandler SelectedIndexChanging;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (WM_REFLECT + WM_NOTIFY))
            {
                NMHDR hdr = (NMHDR)(Marshal.PtrToStructure(m.LParam, typeof(NMHDR)));
                if (hdr.code == TCN_SELCHANGING)
                {
                    TabPage tp = TestTab(PointToClient(Cursor.Position));
                    if (tp != null)
                    {
                        TabPageChangeEventArgs e = new TabPageChangeEventArgs(base.SelectedTab, tp);
                        SelectedIndexChanging?.Invoke(this, e);
                        if (e.Cancel || tp.Enabled == false)
                        {
                            m.Result = new IntPtr(1);
                            return;
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }

        private TabPage TestTab(Point pt)
        {
            for (int index = 0; index <= TabCount - 1; index++)
            {
                if (GetTabRect(index).Contains(pt.X, pt.Y))
                    return TabPages[index];
            }
            return null;
        }

    }

    public class TabPageChangeEventArgs : EventArgs
    {
        private TabPage _Selected = null;
        private TabPage _PreSelected = null;
        public bool Cancel = false;

        public TabPage CurrentTab
        {
            get
            {
                return _Selected;
            }
        }

        public TabPage NextTab
        {
            get
            {
                return _PreSelected;
            }
        }

        public TabPageChangeEventArgs(TabPage CurrentTab, TabPage NextTab)
        {
            _Selected = CurrentTab;
            _PreSelected = NextTab;
        }
    }
    
    public delegate void SelectedTabPageChangeEventHandler(object sender, TabPageChangeEventArgs e);
}