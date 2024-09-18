using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade as a percentage (example: 98): ");
        string userGrade = Console.ReadLine();
        int gradePercent = int.Parse(userGrade);
        string letter = null;
        string sign = null;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";   
        }

        if (gradePercent >= 93)
        {
            sign = null;
        }
        else if (gradePercent < 60)
        {
            sign = null;
        }
        else if (gradePercent % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercent % 10 < 3)
        {
            sign = "-";
        }
        

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class. Good luck in the future.");
        }
    }
}