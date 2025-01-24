using System;

namespace Fractions
{
    public class Fraction
    {
        
        private int top;
        private int bottom;

        // Constructor with no parameters, initializes the fraction as 1/1
        public Fraction()
        {
            top = 1;
            bottom = 1;
        }

        // Constructor with one parameter (int top), bottom is set to 1
        public Fraction(int top)
        {
            this.top = top;
            this.bottom = 1;
        }

        // Constructor with two parameters (int top and  int bottom)
        public Fraction(int top, int bottom)
        {
            this.top = top;
            this.bottom = bottom;
        }

        // Getter and Setter method for top
        public int GetTop()
        {
            return top;
        }

        public void SetTop(int top)
        {
            this.top = top;
        }

        // Getter and Setter method for bottom
        public int GetBottom()
        {
            return bottom;
        }

        public void SetBottom(int bottom)
        {
            if (bottom != 0) 
            {
                this.bottom = bottom;
            }
            else
            {
                Console.WriteLine("Denominator can't be zero.");
            }
        }

        // Method to return the fraction in the form "top/bottom"
        public string GetFractionString()
        {
            return $"{top}/{bottom}";
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)top / bottom;
        }
    }
}
