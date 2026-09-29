using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_TemplateMethod_DP
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            BaseOperation2();
            RequiredOperation2();
        }

        protected void BaseOperation1() => Console.WriteLine("AbstractClass: Base Operation 1");
        protected void BaseOperation2() => Console.WriteLine("AbstractClass: Base Operation 2");

        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();
    }
}
