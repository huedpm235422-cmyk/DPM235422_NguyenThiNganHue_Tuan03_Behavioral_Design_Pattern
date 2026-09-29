using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Visitor_Real_TinhThue_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- VISITOR PATTERN (THỰC TẾ: TÍNH THUẾ) ---\n");

            List<SanPham> gioHang = new List<SanPham>
            {
                new SanPham("Rượu vang", 100000, 0.3),
                new SanPham("Gạo", 200000, 0.0)
            };

            IThueVisitor mayTinhThue = new ThueVATVisitor();
            double tongTien = 0;

            foreach (var sp in gioHang)
            {
                tongTien += sp.Accept(mayTinhThue);
            }

            Console.WriteLine($"\n=> Tổng tiền phải trả (đã gồm thuế): {tongTien} VNĐ");
            Console.ReadLine();
        }
    }
}
