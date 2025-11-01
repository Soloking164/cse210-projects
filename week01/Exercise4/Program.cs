using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        List <int> numbers = new List <int>();

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);
        }

        decimal count = 0;
        decimal total = 0;
        int maxNumber = 0;
        int smallestPositiveNumber = 1000000;

        foreach (int item in numbers)
        {
            total += item;
            count++;

            if (item > maxNumber)
            {
                maxNumber = item;
            }

            if (item > 0)
            {
                if (item < smallestPositiveNumber)
                {
                    smallestPositiveNumber = item;
                }
            }

        }
        
        decimal average = total / count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
    }
}