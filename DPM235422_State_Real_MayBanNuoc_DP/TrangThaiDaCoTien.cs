using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    public class TrangThaiDaCoTien : IMayBanNuocState
    {
        public void NapTien(MayBanNuoc may)
        {
            Console.WriteLine("Máy đã có tiền rồi.");
        }

        public void MuaNuoc(MayBanNuoc may)
        {
            Console.WriteLine("Đang xuất nước ra khay... Cảm ơn!");
            may.SoLuongNuoc--;

            if (may.SoLuongNuoc > 0)
                may.State = new TrangThaiChoTien();
            else
                may.State = new TrangThaiHetHang();
        }
    }
}
