using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Real_XuatBaoCao_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- TEMPLATE METHOD (THỰC TẾ: XUẤT BÁO CÁO) ---\n");

            BaoCaoTemplate pdfReport = new BaoCaoPDF();
            pdfReport.XuatBaoCao();

            BaoCaoTemplate excelReport = new BaoCaoExcel();
            excelReport.XuatBaoCao();

            Console.ReadLine();
        }
    }
}
