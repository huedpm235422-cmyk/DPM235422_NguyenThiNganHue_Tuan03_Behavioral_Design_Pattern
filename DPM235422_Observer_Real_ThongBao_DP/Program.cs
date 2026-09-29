using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Observer_Real_ThongBao_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- OBSERVER PATTERN (THỰC TẾ: THÔNG BÁO YOUTUBE) ---\n");

            YoutubeChannel channel = new YoutubeChannel();

            User user1 = new User("Nam");
            User user2 = new User("Hương");
            User user3 = new User("Minh");

            // Nam và Hương đăng ký kênh
            channel.Subscribe(user1);
            channel.Subscribe(user2);

            channel.UploadVideo("Học Design Pattern siêu dễ");

            // Minh đăng ký, Nam hủy đăng ký
            channel.Subscribe(user3);
            channel.Unsubscribe(user1);

            channel.UploadVideo("Ứng dụng Observer trong thực tế");

            Console.ReadLine();
        }
    }
}
