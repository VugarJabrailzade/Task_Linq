using System;
using System.Linq;

namespace task2
{


    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            
            var res = from c in cities where c.StartsWith('C') && c.EndsWith('A') select c;
            foreach (var c in res)
            {
                Console.WriteLine(c);
            }






        }
    }
}