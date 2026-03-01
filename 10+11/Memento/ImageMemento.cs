using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11.Memento
{
    public class ImageMemento
    {
        public Bitmap State { get; private set; }
        public string LogState { get; private set; }

        public ImageMemento(Bitmap bitmap, string log)
        {
            this.State = new Bitmap(bitmap);
            this.LogState = log;
        }
    }
}
