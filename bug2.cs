using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 15, 20 };

        // Bug 1: Wrong loop condition
        for (int i = 0; i <= arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        // Bug 2: Null reference
        string message = null;
        Console.WriteLine(message.Trim());

        // Bug 3: Divide by zero
        int x = 100;
        int y = 0;
        Console.WriteLine(x / y);

        // Bug 4: Format exception
        string input = "12A";
        int number = Convert.ToInt32(input);

        // Bug 5: Logic error
        int marks = 40;
        if (marks > 40)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
