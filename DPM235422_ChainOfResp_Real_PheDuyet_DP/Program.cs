using System;

namespace DPM235422_ChainOfResp_Real_PheDuyet_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- CHAIN OF RESPONSIBILITY (THỰC TẾ: PHÊ DUYỆT CHI PHÍ) ---\n");

            NhanVien quanLy = new QuanLy();
            NhanVien giamDoc = new GiamDoc();
            NhanVien tongGiamDoc = new TongGiamDoc();

            quanLy.SetCapTren(giamDoc);
            giamDoc.SetCapTren(tongGiamDoc);

            Console.WriteLine("Yêu cầu 1: Mua văn phòng phẩm (5,000,000 VND)");
            quanLy.PheDuyetChiPhi(5000000);

            Console.WriteLine("\nYêu cầu 2: Mua laptop cho nhân sự mới (30,000,000 VND)");
            quanLy.PheDuyetChiPhi(30000000);

            Console.WriteLine("\nYêu cầu 3: Tổ chức sự kiện Year End Party (200,000,000 VND)");
            quanLy.PheDuyetChiPhi(200000000);

            Console.ReadLine();
        }
    }
}