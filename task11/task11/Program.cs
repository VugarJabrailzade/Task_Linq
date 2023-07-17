using System;
using System.Linq;


namespace task11
{


    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>() { "Sumqayit", "Quba", "Qebele", "Baki", "Sheki", "Qax"};

           
            
            var last = list.OrderBy(x => x.Length).ThenBy(x => x ).ToList();
            foreach ( var s in last )
            {
                Console.WriteLine(s);
            }



        }
    }
}