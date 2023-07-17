using System;
using System.Linq;


namespace task12
{


    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {-4,-2, 1, 3, 6, 8, 9, 12, 13, 14, 15, 16, };
            
            var res = from x in list 
                      where x > 0
                      where x < 12
                      select x;

            Console.WriteLine("The numbers within the range of 1 to 12 are :");
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }


        }
    }
}