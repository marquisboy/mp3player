using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mp3Player
{
    public class ProgressBarExt : ProgressBar
    {
        public bool DoPaintEvent { get; set; } = true;
        private Color BarColor;

        public ProgressBarExt(int min = 0, int max = 100)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Minimum = min;
            this.Maximum = max;
            BarColor = Color.FromArgb(205, 0, 0);
            //DoPaintEvent = dopaint;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DoPaintEvent)
            {
                LinearGradientBrush brush = null;
                Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
                double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

                rec.Width = (int)((rec.Width * scaleFactor) - 4);
                rec.Height -= 4;
                BarColor = Color.FromArgb(255 - (Value*2), 0 + (Value * 2),0);
                brush = new LinearGradientBrush(rec, BarColor, BarColor, LinearGradientMode.Horizontal);

                e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
            }
        }
    }
}
