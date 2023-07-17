using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;


namespace task14
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 1, 2, 8, 9, 5, 3, 5, 1, 2, 9 };

            var res = from s in numb
                      group s by s into sGroup
                      select sGroup;

            foreach ( var Group in res )
            {
                    Console.WriteLine($"Number {Group.First()}: {Group.Count<int>()}");
                
            }


        }
    }
}