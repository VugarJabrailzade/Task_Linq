using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace task9
{


    class Program
    {
        static void Main(string[] args)
        {

            List<char> listChar = new List<char>();
            listChar.Add('m');
            listChar.Add('n');
            listChar.Add('o');
            listChar.Add('p');
            listChar.Add('q');

            Console.WriteLine("Char list:");
            foreach (char c in listChar)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Here is the list after removing the three items starting from the item index 1 from the list :");
            listChar.RemoveRange(1, 3);
            foreach (char c in listChar)
            {
                Console.WriteLine("Char:{0}",c);
            }





        }
    }
}