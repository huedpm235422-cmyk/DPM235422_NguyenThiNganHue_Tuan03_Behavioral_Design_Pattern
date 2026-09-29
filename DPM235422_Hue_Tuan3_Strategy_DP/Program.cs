using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Strategy_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- STRATEGY PATTERN (LÝ THUYẾT) ---");
            Context context = new Context();

            context.SetStrategy(new ConcreteStrategyAdd());
            Console.WriteLine($"Phep cong (5 + 3): {context.ExecuteStrategy(5, 3)}");

            context.SetStrategy(new ConcreteStrategyMultiply());
            Console.WriteLine($"Phep nhan (5 * 3): {context.ExecuteStrategy(5, 3)}");

            Console.ReadLine();
        }
    }
}
