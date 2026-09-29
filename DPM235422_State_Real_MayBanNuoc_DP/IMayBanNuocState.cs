using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_State_Real_MayBanNuoc_DP
{
    public interface IMayBanNuocState
    {
        void NapTien(MayBanNuoc may);
        void MuaNuoc(MayBanNuoc may);
    }
}
