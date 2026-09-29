using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Visitor_DP
{
    public interface IVisitor
    {
        void VisitElementA(ConcreteElementA element);
        void VisitElementB(ConcreteElementB element);
    }
}
