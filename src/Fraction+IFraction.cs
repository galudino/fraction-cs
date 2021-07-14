/*!
    \file       Fraction+IFraction.cs
    \brief      Implements the methods in the IFraction interface 

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction : IFraction
    {
        public void Set(int numerator, int denominator)
        {
            switch (denominator)
            {
                case 0:
                    throw new DivisionByZero();
                case 1:
                    Numerator = numerator;
                    Denominator = denominator;
                    break;
            }

            var gcd = GreatestCommonMultiple(numerator, denominator);

            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }
        
        public Fraction Add(Fraction operand)
        {
            return Evaluate(operand, (a, b) => { return a + b; });
        }

        public Fraction Subtract(Fraction operand)
        {
            return Evaluate(operand, (a, b) => { return a - b; });
        }

        public Fraction Multiply(Fraction operand)
        {
            return Evaluate(operand, (a, b) => { return a * b; });
        }

        public Fraction Divide(Fraction operand)
        {
            return Evaluate(operand, (a, b) => { return a / b; });
        }

        public Fraction ChangeToReciprocal()
        {
            var numerator = Numerator;
            Numerator = Denominator;
            Denominator = numerator;
            return this;
        }
    }
}
