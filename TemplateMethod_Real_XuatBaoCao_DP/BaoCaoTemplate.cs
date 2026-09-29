using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Real_XuatBaoCao_DP
{
    public abstract class BaoCaoTemplate
    {
        public void XuatBaoCao()
        {
            TaoTieuDe();
            DinhDangDuLieu();
            LuuBaoCao();
        }

        protected void TaoTieuDe() => Console.WriteLine("== BÁO CÁO DOANH THU ==");

        protected abstract void DinhDangDuLieu();
        protected abstract void LuuBaoCao();
    }
}
