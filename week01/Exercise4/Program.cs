using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int> ();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int userInput;

        while (true)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
                break;

                numbers.Add(userInput);

        }
        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;  
                
                
                if (number > max)
                {
                    max = number;
                }
            }

            // Calculate the average/ double is better that float
            double average = (double)sum / numbers.Count;

            // Output the results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

                




    }
}