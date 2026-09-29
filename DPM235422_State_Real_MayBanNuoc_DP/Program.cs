using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- STATE (THỰC TẾ: MÁY BÁN NƯỚC) ---\n");

            MayBanNuoc may = new MayBanNuoc(1);
            may.MuaNuoc();
            may.NapTien();
            may.MuaNuoc();

            Console.WriteLine("\n-- Khách tiếp theo --");
            may.NapTien();

            Console.ReadLine();
        }
    }
}
