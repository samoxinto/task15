using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());

            if (a == 6 || a == 7)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
