﻿using System;
class MainClass
{
    static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;

        Console.Write("Введите имя: ");
        User.Name = Console.ReadLine();

        User.Dishes = new string[5];

        for (int i = 0; i < User.Dishes.Length; i++)
        {
            Console.WriteLine("Введите любимое блюдо номер {0}", i + 1);
            User.Dishes[i] = Console.ReadLine();
        }

        Console.ReadKey();
    }
}