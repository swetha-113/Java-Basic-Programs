using System;
using System.Collections.Generic;

class Program
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
        Console.WriteLine(total / count); // Divide by zero
    }
}


