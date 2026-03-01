using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11.Memento
{
    public class History
    {
        private Stack<ImageMemento> history = new Stack<ImageMemento>();

        public void SaveState(Bitmap bitmap, string log)
        {
            history.Push(new ImageMemento(bitmap, log));
        }

        public ImageMemento Undo()
        {
            if (history.Count > 0)
                return history.Pop();
            return null;
        }

        public int Count => history.Count;
    }
}
