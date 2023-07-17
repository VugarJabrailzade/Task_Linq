using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace task6
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> list = new List<int>(12) { 1, 2, 4, 5, 6, 7, 12, 15, 16, 19, 21, 24 };



            var res = from s in list where s % 2 == 0 select s;
            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

        }
    }
}