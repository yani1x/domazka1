using System;

class Program
{
    static void Main()
    {
        Person p = new Student("Іван", 20, "Київський університет");
        p.PrintInfo(); // Викликає Student.PrintInfo

        Person dima = new ScoolStudent("Діма", 15, "Ліцей №5");
        dima.PrintInfo(); // Викликає ScoolStudent.PrintInfo

        Console.ReadLine(); // Щоб консоль не закрилася одразу
    }
}
