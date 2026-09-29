using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Real_XuatBaoCao_DP
{
    public class BaoCaoExcel : BaoCaoTemplate
    {
        protected override void DinhDangDuLieu()
        {
            Console.WriteLine("-> Đổ dữ liệu vào các hàng và cột cho Excel...");
        }

        protected override void LuuBaoCao()
        {
            Console.WriteLine("=> Đã lưu file: BaoCao.xlsx\n");
        }
    }
}
