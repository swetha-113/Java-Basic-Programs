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
        int[] marks = { 85, 90, 78, 92 };

        // Bug 1: Off-by-one error
        for (int i = 0; i <= marks.Length; i++)
        {
            Console.WriteLine(marks[i]);
        }

        // Bug 2: Division by zero
        int totalStudents = 0;
        if (totalStudents == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        double average = 100 / totalStudents;  // safe: zero-checked above
        Console.WriteLine("Average: " + average);

        // Bug 3: Null reference
        Student student = null;
        Console.WriteLine(student.Name);

        // Bug 4: Wrong comparison
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD"); // Fixed: use env var
        if (password == "admin123")
        {
            Console.WriteLine("Login Successful");
        }

        // Bug 5: Overflow issue
        byte value = 255;
        value++;

        Console.WriteLine(value);
    }
}

class Student
{
    public string Name { get; set; }
}
