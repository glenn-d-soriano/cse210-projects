using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        // Determine the letter grade based on the percentage
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Check if the user passed or failed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the test!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Please keep trying until you pass!");
        }




    }
}