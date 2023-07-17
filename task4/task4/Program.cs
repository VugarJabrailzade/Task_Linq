using System;
using System.Linq;


namespace task4
{



    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
        
            Console.WriteLine("How many records you want display:");
            int input =int.Parse(Console.ReadLine());

            Console.WriteLine("Records:");
            list.Sort();
            list.Reverse();
            foreach (var i in list.Take(input))
            {
                Console.WriteLine(i);
            }


           
            


        }
    }
}