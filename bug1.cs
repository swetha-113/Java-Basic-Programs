using System;

class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Bob", "Charlie" };

        // Bug 1: Index out of range
        Console.WriteLine(names[3]);

        // Bug 2: Null reference
        string text = null;
        Console.WriteLine(text.ToUpper());

        // Bug 3: Incorrect condition
        int age = 18;
        if (age > 18)
        {
            Console.WriteLine("Eligible to vote");
        }

        // Bug 4: Infinite loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
        }

        // Bug 5: Format exception
        string number = "ABC";
        int num = int.Parse(number);

        Console.WriteLine(num);
    }
}
