using System;

public class ScoolStudent : Person
{
    public string School { get; set; }

    public ScoolStudent(string name = "Unknown", int age = 0, string school = "School #1")
        : base(name, age)
    {
        School = school;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"School Student: Name = {Name}, Age = {Age}, School = {School}");
    }
}
