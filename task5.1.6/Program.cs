using System;
using System.Drawing;
using System.Net.Security;

class MainClass
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int x = 0;

        for (int i = 0; i < result.Length; i++)
        {
            for (int k = i + 1; k < result.Length; k++)
            {
                if (result[i] > result[k])
                {
                    x = result[k];
                    result[k] = result[i];
                    result[i] = x;
                }

            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        foreach (int i in GetArrayFromConsole())
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}