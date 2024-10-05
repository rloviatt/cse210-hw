using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int userInt = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userInt != 0)
        {
            Console.Write("Enter number: ");
            userInt = int.Parse(Console.ReadLine());
            if (userInt != 0)
            {
                numbers.Add(userInt);
            }
        }

        int total = 0;
        int max = 0;
        int minPos = 999999999;
        int size = numbers.Count;
        foreach (int number in numbers)
        {
            total += number;
            if (number > max)
            {
                max = number;
            }
            if (number > 0)
            {
                if (number < minPos)
                {
                    minPos = number;
                }
            }
        }
        float average = ((float)total) / size;
    
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minPos}");
    }
}