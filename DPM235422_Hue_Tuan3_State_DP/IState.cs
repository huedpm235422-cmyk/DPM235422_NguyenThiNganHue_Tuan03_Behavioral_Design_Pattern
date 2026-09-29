using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_State_DP
{
    public interface IState
    {
        void Handle(Context context);
    }
}
