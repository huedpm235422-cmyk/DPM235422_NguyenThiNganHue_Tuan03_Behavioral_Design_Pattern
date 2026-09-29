using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Strategy_Real_GiamGia_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- STRATEGY (THỰC TẾ: TÍNH TIỀN HÓA ĐƠN) ---\n");

            HoaDon hd = new HoaDon(200000);

            Console.WriteLine("Khách bình thường:");
            hd.InHoaDon();

            Console.WriteLine("\nKhách Sinh Viên:");
            hd.ApDungMaGiamGia(new GiamGiaSinhVien());
            hd.InHoaDon();

            Console.ReadLine();
        }
    }
}
