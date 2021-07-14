/*!
    \file       Fraction+IComparable.cs
    \brief      Implements the Comparable method from the IComparable interface

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction : System.IComparable<Fraction>
    {
        public int CompareTo(Fraction other)
        {
            var lcd = LeastCommonMultiple(Denominator, other.Denominator);

            var numerator = (Numerator * lcd) / Denominator;
            var denominator = (other.Denominator * lcd) / other.Numerator;

            return numerator - denominator;
        }
    }
}
