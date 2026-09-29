using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Strategy_Real_GiamGia_DP
{
    public class HoaDon
    {
        private IGiamGiaStrategy _giamGiaStrategy;
        private double _giaGoc;

        public HoaDon(double giaGoc)
        {
            _giaGoc = giaGoc;
            _giamGiaStrategy = new GiamGiaThongThuong();
        }

        public void ApDungMaGiamGia(IGiamGiaStrategy strategy)
        {
            _giamGiaStrategy = strategy;
        }

        public void InHoaDon()
        {
            double giaCuoi = _giamGiaStrategy.TinhTien(_giaGoc);
            Console.WriteLine($"Giá gốc: {_giaGoc} VNĐ => Cần thanh toán: {giaCuoi} VNĐ");
        }
    }
}
