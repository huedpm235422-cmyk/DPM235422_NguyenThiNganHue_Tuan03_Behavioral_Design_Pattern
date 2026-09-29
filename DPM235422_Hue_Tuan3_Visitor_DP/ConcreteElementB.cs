using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Visitor_DP
{
    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor) => visitor.VisitElementB(this);
        public string FeatureB() => "B";
    }
}
