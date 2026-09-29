using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Iterator_Real_DuyetMenu_DP
{
    public class MenuIterator : IIterator
    {
        private List<MonAn> _danhSachMonAn;
        private int _viTri = 0;

        public MenuIterator(List<MonAn> danhSach)
        {
            _danhSachMonAn = danhSach;
        }

        public bool HasNext()
        {
            return _viTri < _danhSachMonAn.Count;
        }

        public MonAn Next()
        {
            MonAn monAn = _danhSachMonAn[_viTri];
            _viTri++;
            return monAn;
        }
    }
}
