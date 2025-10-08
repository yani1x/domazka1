using System;

public class Student : Person
{
    public string University { get; set; }

    public Student(string name, int age, string university)
        : base(name, age) // використання base
    {
        University = university;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Student: Name = {Name}, Age = {Age}, University = {University}");
    }
}
