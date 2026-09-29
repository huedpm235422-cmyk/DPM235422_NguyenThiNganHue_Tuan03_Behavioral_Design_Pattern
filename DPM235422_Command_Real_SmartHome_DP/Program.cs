using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Command_Real_SmartHome_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- COMMAND PATTERN (THỰC TẾ: ĐIỀU KHIỂN SMART HOME) ---\n");

            Light livingRoomLight = new Light();
            ICommand turnOn = new TurnOnLightCommand(livingRoomLight);
            ICommand turnOff = new TurnOffLightCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();

            Console.WriteLine("Nhấn nút bật đèn trên Remote:");
            remote.SetCommand(turnOn);
            remote.PressButton();

            Console.WriteLine("\nNhấn nút tắt đèn trên Remote:");
            remote.SetCommand(turnOff);
            remote.PressButton();

            Console.ReadLine();
        }
    }
}
