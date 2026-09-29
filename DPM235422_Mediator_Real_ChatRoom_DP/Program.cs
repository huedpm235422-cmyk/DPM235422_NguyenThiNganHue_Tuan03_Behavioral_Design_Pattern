using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Mediator_Real_ChatRoom_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- MEDIATOR PATTERN (THỰC TẾ: CHAT ROOM) ---\n");

            ChatRoom room = new ChatRoom();

            User user1 = new ChatUser(room, "Ngân Huế");
            User user2 = new ChatUser(room, "Văn A");
            User user3 = new ChatUser(room, "Thị B");

            room.Register(user1);
            room.Register(user2);
            room.Register(user3);

            user1.Send("Chào mọi người!");
            Console.WriteLine();
            user2.Send("Chào Huế nhé!");

            Console.ReadLine();
        }
    }
}
