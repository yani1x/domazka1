using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Person: Name = {Name}, Age = {Age}");
    }
}
