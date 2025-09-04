using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_11
{
    internal class BitmapCopy
    {
        public static Bitmap CopyArea(Bitmap source, Rectangle area)
        {
            if (area.Right > source.Width || area.Bottom > source.Height)
            {
                MessageBox.Show("Область копіювання за межами забраження!");
                return null;
            }
            
            Bitmap copy = new Bitmap(area.Width, area.Height);
            Graphics g = Graphics.FromImage(copy);
            g.DrawImage(source, new Rectangle(0, 0, copy.Width, copy.Height), area, GraphicsUnit.Pixel);
            return copy;
        }
    }
}
