using System;
using System.Linq;


namespace task10
{
    class Program
    {
        public static void Main(string[] args)
        {
              List<string> list = new List<string>() { "Honey", "Apple", "Butter", "Yoghurt", "Cheese" };
            
              list = list.OrderBy(x => x).ToList();

                foreach (var item in list)
                {
                Console.WriteLine(item);
                }
                
            
            

        }
    }
}