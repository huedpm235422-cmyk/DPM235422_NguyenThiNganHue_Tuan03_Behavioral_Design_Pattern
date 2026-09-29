using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Real_XuatBaoCao_DP
{
    public class BaoCaoPDF : BaoCaoTemplate
    {
        protected override void DinhDangDuLieu()
        {
            Console.WriteLine("-> Dàn trang bảng biểu Vector cho PDF...");
        }

        protected override void LuuBaoCao()
        {
            Console.WriteLine("=> Đã lưu file: BaoCao.pdf\n");
        }
    }
}
