using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta
{
    public class NotifyPanel: System.Windows.Forms.Button
    {
        public NotifyPanel()
        {

        }
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                if (_number == value) return;
                _number = value;
                Invalidate();
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //base.DrawImageAndText(graphics, controlState, imageTextRect);
            if (Number == 0) return;
            int height = 20;
            var rect = new Rectangle(this.Width-5 - (height), (this.Height-5 - height) / 2, height, height);
            graphics.FillEllipse(Brushes.OrangeRed, rect);
            graphics.DrawEllipse(new Pen(Color.Orange, 2), rect);
            string text = Number.ToString();
            SizeF textsize = graphics.MeasureString(text, Font);
            graphics.DrawString(text, Font, Brushes.White, rect.X + ((height - textsize.Width) / 2), rect.Y + ((height - textsize.Height) / 2));
        }

    }
}
