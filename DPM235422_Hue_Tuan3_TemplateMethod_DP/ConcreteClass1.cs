using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_TemplateMethod_DP
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass1: Thực hiện thao tác bắt buộc 1.");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1: Thực hiện thao tác bắt buộc 2.");
        }
    }
}
