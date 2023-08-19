using System;
using System.Collections.Generic;

class Student
{
    public string StudentID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Dictionary<string, double> Subjects { get; } = new Dictionary<string, double>();

    public void AddGrade(string subject, double grade)
    {
        Subjects[subject] = grade;
    }

    public double CalculateAverageGrade()
    {
        
        if (Subjects.Count == 0)
            return 0;

        double totalGrade = 0;
        foreach (var grade in Subjects.Values)
        {
            totalGrade += grade;
        }
        return totalGrade / Subjects.Count;
    }

    public string FindHighestGradeSubject()
    {
        if (Subjects.Count == 0)
            return null;

        string highestSubject = null;
        double highestGrade = double.MinValue;
        foreach (var pair in Subjects)
        {
            if (pair.Value > highestGrade)
            {
                highestGrade = pair.Value;
                highestSubject = pair.Key;
            }
        }
        return highestSubject;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("Subjects and Grades:");
        foreach (var pair in Subjects)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student
        {
            StudentID = "12345",
            Name = "John Doe",
            Age = 18
        };
        Student student2 = new Student
        {
            StudentID = "12345",
            Name = "John Rock",
            Age = 19
        };
        student1.AddGrade("Math", 90);
        student1.AddGrade("Science", 85);
        student1.AddGrade("History", 75);

        student1.DisplayDetails();

        List<Student> students = new List<Student>() { 
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" },
        new Student { Age=20,StudentID="101",Name="Leo" }
        };

        students.Add(student1);
        students.Add(student2);

        Console.WriteLine($"Average Grade: {student1.CalculateAverageGrade()}");
        Console.WriteLine($"Highest Grade Subject: {student1.FindHighestGradeSubject()}");
             
    }
}
