using System;

namespace DPM235422_ChainOfResp_Real_PheDuyet_DP
{
    public class QuanLy : NhanVien
    {
        public override void PheDuyetChiPhi(double soTien)
        {
            if (soTien <= 10000000)
            {
                Console.WriteLine($"[Quản lý] Đã phê duyệt khoản chi {soTien} VND.");
            }
            else if (_capTren != null)
            {
                Console.WriteLine($"[Quản lý] Số tiền {soTien} quá thẩm quyền, chuyển lên Giám đốc...");
                _capTren.PheDuyetChiPhi(soTien);
            }
        }
    }
}