﻿using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Мишанкин А
            // 4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.

            Console.WriteLine("Введите a");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b");
            double b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = a;

            Console.WriteLine($"a={a} b={b}");

        }
    }
}
