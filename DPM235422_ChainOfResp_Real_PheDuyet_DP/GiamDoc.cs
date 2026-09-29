using System;

namespace DPM235422_ChainOfResp_Real_PheDuyet_DP
{
    public class GiamDoc : NhanVien
    {
        public override void PheDuyetChiPhi(double soTien)
        {
            if (soTien <= 50000000)
            {
                Console.WriteLine($"[Giám đốc] Đã phê duyệt khoản chi {soTien} VND.");
            }
            else if (_capTren != null)
            {
                Console.WriteLine($"[Giám đốc] Số tiền {soTien} quá thẩm quyền, chuyển lên Tổng Giám đốc...");
                _capTren.PheDuyetChiPhi(soTien);
            }
        }
    }
}