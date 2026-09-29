using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Memento_DP
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}
