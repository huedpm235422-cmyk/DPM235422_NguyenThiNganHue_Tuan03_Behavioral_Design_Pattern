using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Observer_Real_ThongBao_DP
{
    public interface ISubscriber
    {
        void Update(string videoTitle);
    }
}
