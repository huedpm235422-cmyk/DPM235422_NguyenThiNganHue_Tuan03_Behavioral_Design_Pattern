using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Mediator_Real_ChatRoom_DP
{
    public abstract class User
    {
        protected IChatRoom _chatRoom;
        public string Name { get; set; }

        public User(IChatRoom room, string name)
        {
            _chatRoom = room;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
