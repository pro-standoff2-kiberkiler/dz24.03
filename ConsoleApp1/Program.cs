using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite chas");
            int hour = int.Parse(Console.ReadLine());
            if (hour >= 6 && hour <= 11)
                Console.WriteLine("utro");
            else if (hour >= 12 && hour <= 17)
                Console.WriteLine("День");
            else if (hour >= 18 && hour <= 22)
                Console.WriteLine("Ночь");
            else
        }
    }
}
