using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();  

        string userName = PromptUserName();  // user's name
        int userNumber = PromptUserNumber();  // user's favorite number

        int squaredNumber = SquareNumber(userNumber);  // Square the favorite number

        DisplayResult(userName, squaredNumber);  
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();  
    }

    // prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());  
    }

    // to square the number and return the result
    static int SquareNumber(int number)
    {
        return number * number;  
    }

    // Function to display the result with the name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

}