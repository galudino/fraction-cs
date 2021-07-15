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
        public decimal Decimal => new decimal(Numerator) / new decimal(Denominator);

        public Fraction(int numerator = 0, int denominator = 1) : this()
        {
            Set(numerator, denominator);
        }

        public Fraction(Fraction other) {
            Numerator = other.Numerator;
            Denominator = other.Denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction fraction)
            {
                return Numerator == fraction.Numerator && Denominator == fraction.Denominator;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("[{0} / {1}]", Numerator, Denominator);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
