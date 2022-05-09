using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento_App
{
    public class CircularPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor = Color.Black;
        private Color borderColor2 = Color.Bisque;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        //Constructor
        public CircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        // public int BorderSize { get => borderSize; set => borderSize = value ;  }
        // public Color BorderColor { get => borderColor; set => borderColor = value; }
        //  public Color BorderColor2 { get => borderColor2; set => borderColor2 = value; }
        //  public DashStyle BorderLineStyle { get => borderLineStyle; set => borderLineStyle = value; }
        // public DashCap BorderCapStyle { get => borderCapStyle; set => borderCapStyle = value; }
        // public float GradientAngle { get => gradientAngle; set => gradientAngle = value; }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }
            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }
            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }
            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }
        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.DashStyle = BorderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                //Drawing
                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
