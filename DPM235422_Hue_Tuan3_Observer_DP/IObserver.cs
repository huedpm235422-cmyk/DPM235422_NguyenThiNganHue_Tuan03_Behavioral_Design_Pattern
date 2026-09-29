using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Observer_DP
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
