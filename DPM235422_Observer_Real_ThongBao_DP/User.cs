using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Observer_Real_ThongBao_DP
{
    public class User : ISubscriber
    {
        private string _userName;

        public User(string name)
        {
            _userName = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine($"   -> Gửi thông báo tới {_userName}: Có video mới '{videoTitle}'!");
        }
    }
}
