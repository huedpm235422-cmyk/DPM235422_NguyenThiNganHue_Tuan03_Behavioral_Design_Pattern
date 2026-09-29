using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Visitor_Real_TinhThue_DP
{
    public class SanPham
    {
        public string Ten { get; set; }
        public double GiaGoc { get; set; }
        public double PhanTramThue { get; set; }

        public SanPham(string ten, double gia, double thue)
        {
            Ten = ten;
            GiaGoc = gia;
            PhanTramThue = thue;
        }

        public double Accept(IThueVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
