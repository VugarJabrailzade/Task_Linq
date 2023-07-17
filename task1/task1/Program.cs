using System;

namespace task1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display Weekdays:");
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (var weekDay in weekDays)
            {
                Console.WriteLine(weekDay);
            }

            //var res = from s in weekDays select s;

            //foreach (var s in res)
            //{
            //    Console.WriteLine(s);
            //}









        }
    }


}