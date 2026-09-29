using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Mediator_Real_ChatRoom_DP
{
    public class ChatRoom : IChatRoom
    {
        private List<User> _users = new List<User>();

        public void Register(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // Không gửi lại cho chính người gửi
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}
