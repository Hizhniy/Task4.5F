using System;

class MainClass
{
    static void ChangeAge(ref int age)
    {
        age = 77;
    }
    static void Main()
    {
        int MyAge = Convert.ToInt32(Console.ReadLine());
        ChangeAge(ref MyAge);
        Console.WriteLine(MyAge);
        Console.ReadKey();
    }
}