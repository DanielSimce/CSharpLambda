using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdbaArrow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>() { 10, 54, 36, 98, 145 };

            List<string> vs1 = new List<string>() { "Daniel", "Stefani", "Tomi", "Teo","Dime" };

            var query = vs.FindAll(x => x > 50);

            var names = vs1.FindAll(x => x.StartsWith("D"));

            

            foreach (var item in query)
            {
                Console.WriteLine(item + " ");
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Check();

            

            Console.ReadLine();
        }


        public static void Check() => Console.WriteLine("Lionel Messi");

        
    }
}
