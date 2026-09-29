using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Observer_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- OBSERVER PATTERN (LÝ THUYẾT) ---");
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);
            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);
            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
