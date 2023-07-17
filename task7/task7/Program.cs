using System;
using System.Linq;

namespace task7
{


    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            Console.WriteLine("Here is the list of items:");
            foreach (char c in list)
            {
                  Console.WriteLine(c);

            }

            Console.WriteLine("Here is the list after removing the item 'o' from the list :");
            list.Remove('o');
            foreach (char d in list)
            {
                Console.WriteLine(d);
            }
           



        }
    }
}