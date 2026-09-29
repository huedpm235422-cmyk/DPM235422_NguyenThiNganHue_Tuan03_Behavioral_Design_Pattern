using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Visitor_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- VISITOR PATTERN (LÝ THUYẾT) ---\n");

            List<IElement> elements = new List<IElement> { new ConcreteElementA(), new ConcreteElementB() };
            IVisitor visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            Console.ReadLine();
        }
    }
}
