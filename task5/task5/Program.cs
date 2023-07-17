using System;
using System.Linq;

namespace task5
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string:");
            string input = Console.ReadLine();

            var output = input.Split(' ',',','?','.').Where(x => x == x.ToUpper());
            foreach (var x in output)
            {
                Console.WriteLine(x);
            }
           

        }
    }
}