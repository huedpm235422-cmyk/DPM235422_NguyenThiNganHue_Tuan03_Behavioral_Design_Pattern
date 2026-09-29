using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Mediator_DP
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
