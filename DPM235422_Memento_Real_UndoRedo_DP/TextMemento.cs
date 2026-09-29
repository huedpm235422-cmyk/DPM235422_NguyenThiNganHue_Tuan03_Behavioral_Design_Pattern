using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Memento_Real_UndoRedo_DP
{
    public class TextMemento
    {
        public string Content { get; private set; }

        public TextMemento(string content)
        {
            Content = content;
        }
    }
}
