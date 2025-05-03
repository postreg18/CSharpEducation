using System;

namespace Task4     //Напишите программу, которая считывает из консоли ваше имя и выводит приветственное сообщение.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");    //считывает из консоли ваше имя
            var name = Console.ReadLine();      // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль
        }
    }
}
