using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Mediator_Real_ChatRoom_DP
{
    public class ChatUser : User
    {
        public ChatUser(IChatRoom room, string name) : base(room, name) { }

        public override void Send(string message)
        {
            Console.WriteLine($"[Gửi] {Name}: {message}");
            _chatRoom.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"[Nhận] {Name} nhận được: {message}");
        }
    }
}
