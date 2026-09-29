using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_State_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- STATE PATTERN (LÝ THUYẾT) ---");
            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();

            Console.ReadLine();
        }
    }
    }
