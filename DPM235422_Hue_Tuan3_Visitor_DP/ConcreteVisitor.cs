using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Visitor_DP
{
    public class ConcreteVisitor : IVisitor
    {
        public void VisitElementA(ConcreteElementA element)
        {
            Console.WriteLine($"Visitor đang làm việc với Element {element.FeatureA()}");
        }

        public void VisitElementB(ConcreteElementB element)
        {
            Console.WriteLine($"Visitor đang làm việc với Element {element.FeatureB()}");
        }
    }
}
