using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_State_DP
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateB đang xử lý yêu cầu.");
            context.TransitionTo(new ConcreteStateA());
        }
    }
}
