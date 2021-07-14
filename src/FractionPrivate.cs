/*!
    \file       FractionPrivate.cs
    \brief      Contains private functionality for struct Fraction

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public partial struct Fraction
    {
        private Fraction Evaluate(Fraction operand, System.Func<int, int, int> operation)
        {
            var lcd = LeastCommonMultiple(Denominator, operand.Denominator);
            var numerator = (Numerator * lcd) / Denominator;
            var denominator = (operand.Numerator * lcd) / (operand.Denominator);

            Set(operation(numerator, denominator), lcd);
            return this;
        }

        private static int GreatestCommonMultiple(int lhs, int rhs)
        {
            while (rhs != 0)
            {
                var temp = rhs;
                rhs = lhs % rhs;
                lhs = temp;
            }

            return lhs;
        }

        private static int GreatestCommonMultipleRecursive(int lhs, int rhs)
        {
            return lhs % rhs == 0 ? rhs : GreatestCommonMultipleRecursive(rhs, lhs % rhs);
        }

        private static int LeastCommonMultiple(int lhs, int rhs)
        {
            return (lhs * rhs) / GreatestCommonMultiple(lhs, rhs);
        }
    }
}
