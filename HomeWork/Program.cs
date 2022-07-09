using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Необходимо написать приложение, которое определяет чётное или нечётное число.

            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("Число является чётным");
            }
            else
            {
                Console.Write("Число является нечётным");
            }
        }
    }
}
