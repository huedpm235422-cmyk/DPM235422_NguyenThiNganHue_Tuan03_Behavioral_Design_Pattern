using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Memento_Real_UndoRedo_DP
{
    public class History
    {
        private Stack<TextMemento> _states = new Stack<TextMemento>();

        public void Push(TextMemento memento)
        {
            _states.Push(memento);
        }

        public TextMemento Pop()
        {
            if (_states.Count > 0)
                return _states.Pop();
            return null;
        }
    }
}
