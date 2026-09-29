using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_Iterator_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");
            collection.ReverseDirection();
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
