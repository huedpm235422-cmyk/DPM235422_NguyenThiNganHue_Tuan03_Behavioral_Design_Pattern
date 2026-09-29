using System;

namespace DPM235422_ChainOfResp_Real_PheDuyet_DP
{
    public class TongGiamDoc : NhanVien
    {
        public override void PheDuyetChiPhi(double soTien)
        {
            Console.WriteLine($"[Tổng Giám đốc] Đã trực tiếp phê duyệt khoản chi lớn {soTien} VND.");
        }
    }
}