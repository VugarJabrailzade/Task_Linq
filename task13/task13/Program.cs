using System;
using System.Linq;


namespace task13
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 3, 4, 5, 6, 7, };

            var res = from number in numbers
                      let sqr = number*number
                      where sqr > 0
                      select new { number, sqr };

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }





        }
    }
}