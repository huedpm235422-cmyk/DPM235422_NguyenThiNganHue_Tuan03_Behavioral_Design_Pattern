using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    public class TrangThaiHetHang : IMayBanNuocState
    {
        public void NapTien(MayBanNuoc may)
        {
            Console.WriteLine("Máy hết hàng, vui lòng nhận lại tiền.");
        }

        public void MuaNuoc(MayBanNuoc may)
        {
            Console.WriteLine("Lỗi: Máy đang hết hàng.");
        }
    }
}
