using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Visitor_Real_TinhThue_DP
{
    public interface IThueVisitor
    {
        double Visit(SanPham sp);
    }
}
