using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Iterator_Real_DuyetMenu_DP
{
    public class NhaHangMenu : IMenu
    {
        private List<MonAn> _monAns;

        public NhaHangMenu()
        {
            _monAns = new List<MonAn>();
            _monAns.Add(new MonAn("Phở bò", 45000));
            _monAns.Add(new MonAn("Bún chả", 50000));
            _monAns.Add(new MonAn("Cơm tấm", 40000));
        }

        public IIterator CreateIterator()
        {
            return new MenuIterator(_monAns);
        }
    }
}
