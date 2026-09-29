using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Visitor_DP
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
