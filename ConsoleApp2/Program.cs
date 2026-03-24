using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat pushistic = new Cat();
            pushistic.golos();
            pushistic.lives();
            pushistic.korm();

            cobaka bobik = new cobaka();
            bobik.golos();

            papuch kesha = new papuch();
            kesha.golos();
        }
    }
    interface IAnimal
    {
        void golos();
    }

    class Cat : IAnimal
    {
        public void golos()
        {
            Console.WriteLine("Mew mew");
        }
        public void lives()
        {
            int lives = 9;
            Console.WriteLine("Введите сколько раз умер кошак");
            int liv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"У котака осталось {lives - liv} жизней");
        }
        public void korm()
        {
            Console.WriteLine("Введите вес кашки");
            int ves = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пол кошкая м/ж");
            string pol = Console.ReadLine();
            if (pol == "м")
            {
                Console.WriteLine($"Суточное норма для кота составаляет - {ves * 40} грамм корма");
            }
            if (pol == "ж")
            {
                Console.WriteLine($"Суточное норма для кошки составаляет - {ves * 35} грамм корма");

            }

        }
    }

    class cobaka : IAnimal
    {
        public void golos()
        {
            Console.WriteLine("Gaw Gaw");
        }
    }

    class papuch : IAnimal
    {
        public void golos()
        {
            Console.WriteLine("Кутах кутах");
        }
    }
}

    

   

        

