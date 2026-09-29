using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    public class TrangThaiChoTien : IMayBanNuocState
    {
        public void NapTien(MayBanNuoc may)
        {
            Console.WriteLine("Đã nạp tiền. Vui lòng chọn nước.");
            may.State = new TrangThaiDaCoTien();
        }

        public void MuaNuoc(MayBanNuoc may)
        {
            Console.WriteLine("Lỗi: Bạn chưa nạp tiền!");
        }
    }
}
