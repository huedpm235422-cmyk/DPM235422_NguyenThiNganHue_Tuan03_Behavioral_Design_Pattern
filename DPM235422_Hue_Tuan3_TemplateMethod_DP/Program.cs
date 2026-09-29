using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_TemplateMethod_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- TEMPLATE METHOD (LÝ THUYẾT) ---\n");

            AbstractClass algorithm = new ConcreteClass1();
            algorithm.TemplateMethod();

            Console.ReadLine();
        }
    }
}
