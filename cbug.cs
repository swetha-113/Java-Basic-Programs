using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = 0; i <= numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int a = 10;
        int b = 0;

        int result = a / b;
        Console.WriteLine("Result: " + result);

        string name = null;
        Console.WriteLine(name.Length);
    }
}
