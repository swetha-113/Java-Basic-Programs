using System;
using System.Collections.Generic;

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
        List<string> students = new List<string>();
        students.Add("John");
        students.Add("Alice");

        Console.WriteLine(students[5]); // Index out of range

        string name = null;
        Console.WriteLine(name.Length); // Null reference

        int total = 100;
        int count = 0;
        if (count == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        Console.WriteLine(total / count); // Divide by zero  // safe: zero-checked above
    }
}


