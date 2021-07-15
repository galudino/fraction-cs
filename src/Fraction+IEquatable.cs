/*!
    \file       Fraction+IEquatable.cs
    \brief      Implements the Equals method from the IEquatable interface

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction : System.IEquatable<Fraction>
    {
        public bool Equals(Fraction other)
        {
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }
    }
}
