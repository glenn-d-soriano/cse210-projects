using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World! This is the Fractions Project.");

            // Creating instances split to 4 for Fraction class
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction(5);
            Fraction fraction3 = new Fraction(3, 4);
            Fraction fraction4 = new Fraction(1, 3);

            // Fraction to be shown as string and decimal value
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());

            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction2.GetDecimalValue());

            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine(fraction3.GetDecimalValue());

            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine(fraction4.GetDecimalValue());
        }
    }
}
