using System;
using System.Linq;


namespace task3
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Display numbers greater than 80 are:");
            int[] numbers = { 55, 200, 740, 76, 230, 482, 95 };

            var res = from x in numbers where x >= 80 select x;
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }







        }
    }
}