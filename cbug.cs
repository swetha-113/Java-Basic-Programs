using System;

def your_function(param):
"""One-line summary.

Args:
param: Description.

Returns:
Description of return value.
"""
pass
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

        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        int result = a / b;  // safe: zero-checked above
        Console.WriteLine("Result: " + result);

        string name = null;
        Console.WriteLine(name.Length);
    }
}
