using System;
using System.Drawing;
using System.Net.Security;

class MainClass
{
    static int[] GetArrayFromConsole(ref int num)
    {
        var array = new int[num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static int[] SortArray(int[] sortedarray)
    {
        int temp;
        for (int i = 0; i < sortedarray.Length; i++)
        {
            for (int k = i + 1; k < sortedarray.Length; k++)
            {
                if (sortedarray[i] > sortedarray[k])
                {
                    temp = sortedarray[k];
                    sortedarray[k] = sortedarray[i];
                    sortedarray[i] = temp;
                }
            }
        }
        return sortedarray;
    }
    static void ShowArray(int[] array, bool needtosort = false)
    {
        if (needtosort == true)
        {
            SortArray(array);
        }
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
    static void Main(string[] args)
    {
        var arraynum = 10;
        var array = GetArrayFromConsole(ref arraynum);
        ShowArray(array, true);

        Console.ReadKey();
    }
}