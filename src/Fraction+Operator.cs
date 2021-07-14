/*!
    \file       Fraction+Operator.cs
    \brief      Defines operator overloads for Add/Subtract/Multiply/Divide

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction
    {
        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            return lhs.Add(rhs);
        }

        public static Fraction operator -(Fraction lhs, Fraction rhs)
        {
            return lhs.Subtract(rhs);
        }

        public static Fraction operator *(Fraction lhs, Fraction rhs)
        {
            return lhs.Multiply(rhs);
        }

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {
            return lhs.Divide(lhs);
        }
    }
}
