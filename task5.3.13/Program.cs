using System;

class MainClass
{
    static int[] GetArrayFromConsole(int num)
    {
        var array = new int[num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static int[] SortArrayDesc(int[] array)
    {
        var sortedarray = new int[array.Length];
        Array.Copy(array,sortedarray,array.Length);
        int temp;
        for (int i = 0; i < sortedarray.Length; i++)
        {
            for (int k = i + 1; k < sortedarray.Length; k++)
            {
                if (sortedarray[i] < sortedarray[k])
                {
                    temp = sortedarray[k];
                    sortedarray[k] = sortedarray[i];
                    sortedarray[i] = temp;
                }
            }
        }
        return sortedarray;
    }
    static int[] SortArrayAsc(int[] array)
    {
        var sortedarray = new int[array.Length];
        Array.Copy(array, sortedarray, array.Length);
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
    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(array);
        sortedasc = SortArrayAsc(array);
    }
    static void ShowArray(int[] array)
    {
        SortArray(in array, out int[] sortedar_d, out int[] sortedar_a);
        foreach (int i in sortedar_d)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        foreach (int i in sortedar_a)
        {
            Console.Write(i + " ");
        }
    }
    static void Main(string[] args)
    {
        var array = GetArrayFromConsole(5);
        ShowArray(array);
        Console.ReadKey();
    }
}