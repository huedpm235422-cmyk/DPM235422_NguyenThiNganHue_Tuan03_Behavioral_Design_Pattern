using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Iterator_Real_DuyetMenu_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- ITERATOR PATTERN (THỰC TẾ: DUYỆT MENU) ---\n");

            NhaHangMenu menu = new NhaHangMenu();
            IIterator iterator = menu.CreateIterator();

            Console.WriteLine("MENU NHÀ HÀNG HÔM NAY:");
            while (iterator.HasNext())
            {
                MonAn monAn = iterator.Next();
                Console.WriteLine($"- {monAn.Ten}: {monAn.Gia} VND");
            }

            Console.ReadLine();
        }
    }
}
