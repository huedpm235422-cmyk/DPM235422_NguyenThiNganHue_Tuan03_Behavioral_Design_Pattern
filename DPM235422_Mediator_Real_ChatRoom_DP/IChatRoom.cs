using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Mediator_Real_ChatRoom_DP
{
    public interface IChatRoom
    {
        void SendMessage(string message, User user);
    }
}
