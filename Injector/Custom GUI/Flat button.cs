using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Custom_GUI
{
    /// <summary>
    /// A simplistic looking button
    /// </summary>

    public class FlatButton : Control
    {
        private SolidBrush borderBrush, textBrush,
            Transparent = new SolidBrush(Color.Transparent);
        private Rectangle borderRectangle;
        private bool active = false, over = false;
        private StringFormat stringFormat = new StringFormat();
        private Color OriginalBackColor;

        [Category("Appearance")]
        [Description("Controls the displaying of a border around the button")]
        public bool Border { get; set; } = true;

        [Category("Appearance")]
        [Description("Sets the thickness of the border")]
        public float BorderThickness { get; set; } = 1;

        [Category("Appearance")]
        [Description("Sets the color of the border")]
        public Color BorderColor { get; set; } = Color.FromArgb(150, 150, 150);

        [Category("Appearance")]
        [Description("Sets the color of the button when the mouse is over it")]
        public Color MouseOver { get; set; } = Color.FromArgb(40, 40, 60);

        [Category("Appearance")]
        [Description("Sets the color of the button when the mouse is pressed")]
        public Color Pressed { get; set; } = Color.FromArgb(30, 30, 50);

        public FlatButton()
        {
            ForeColor = Color.FromArgb(200, 200, 200);
            BackColor = Color.FromArgb(30, 30, 30);
            Text = "Flat button";

            OriginalBackColor = BackColor;


            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Paint += FlatButton_Paint;
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e)
        {
            if (!over && !active)
                OriginalBackColor = BackColor;

            borderBrush = new SolidBrush(BorderColor);
            textBrush = new SolidBrush(ForeColor);

            borderRectangle = new Rectangle((int)BorderThickness - 1, (int)BorderThickness - 1, Width - ((int)BorderThickness*2) + 1, Height - ((int)BorderThickness*2) + 1);
            e.Graphics.DrawRectangle(new Pen(Border ? borderBrush : Transparent, BorderThickness), borderRectangle);
            e.Graphics.DrawString(Text, Font, textBrush, borderRectangle, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.BackColor = MouseOver;
            over = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackColor = OriginalBackColor;
            over = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = Pressed;
            active = true;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = over ? MouseOver : OriginalBackColor;
            active = false;
        }
    }
}