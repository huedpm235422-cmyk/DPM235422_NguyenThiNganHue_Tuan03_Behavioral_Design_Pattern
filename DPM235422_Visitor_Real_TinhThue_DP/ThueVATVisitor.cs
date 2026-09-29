using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Visitor_Real_TinhThue_DP
{
    public class ThueVATVisitor : IThueVisitor
    {
        public double Visit(SanPham sp)
        {
            double tienThue = sp.GiaGoc * sp.PhanTramThue;
            Console.WriteLine($"Thuế {sp.Ten} ({sp.PhanTramThue * 100}%): {tienThue}");
            return sp.GiaGoc + tienThue;
        }
    }
}
