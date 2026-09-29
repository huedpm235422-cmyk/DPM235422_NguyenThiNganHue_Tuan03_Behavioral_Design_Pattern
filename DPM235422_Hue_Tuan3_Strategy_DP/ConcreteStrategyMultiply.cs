using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Strategy_DP
{
    public class ConcreteStrategyMultiply : IStrategy
    {
        public int Execute(int a, int b) => a * b;
    }
}
