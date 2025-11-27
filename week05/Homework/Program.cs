using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment assignment1 = new Assingment("Eze Solomon Nwaka", "Impersonation: An Academic Crime");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment assignment2 = new MathAssignment("Eze Solomon Nwaka", "New General Maths", "8.0", "12-23");
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Nigerian History", "Solomon Smith", "The Ngerian Civil War");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}  