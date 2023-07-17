using System;
using System.Linq;

namespace task8
{


    class Program
    {
       static void Main(string[] args)
        {
            List<char> list = new List<char>();
            list.Add('m');
            list.Add('n');
            list.Add('p');
            list.Add('q');
            list.Add('o');

            Console.WriteLine("Char list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Here is the list after removing item index 3 from the list:");
            list.RemoveAt(3);
            foreach (var last in list)
            {
                Console.WriteLine(last);
            }

        }
    }
}