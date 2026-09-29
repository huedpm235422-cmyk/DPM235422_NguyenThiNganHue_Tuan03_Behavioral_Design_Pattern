using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    public class MayBanNuoc
    {
        public IMayBanNuocState State { get; set; }
        public int SoLuongNuoc { get; set; }

        public MayBanNuoc(int soLuong)
        {
            SoLuongNuoc = soLuong;
            if (soLuong > 0)
                State = new TrangThaiChoTien();
            else
                State = new TrangThaiHetHang();
        }

        public void NapTien() => State.NapTien(this);
        public void MuaNuoc() => State.MuaNuoc(this);
    }
}
