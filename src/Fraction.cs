/*!
    \file       Fraction.cs
    \brief      Abstraction for a Fraction -- a ratio of integers

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator) : this()
        {
            Set(numerator, denominator);
        }

        public Fraction(Fraction other) {
            Numerator = other.Numerator;
            Denominator = other.Denominator;
        }

        public float AsFloat()
        {
            return Numerator / Denominator;
        }

        public double AsDouble()
        {
            return Numerator / Denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction fraction)
            {
                return CompareTo(fraction) == 0;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("[{0} / {1}]: {2}", Numerator, Denominator, AsFloat());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
