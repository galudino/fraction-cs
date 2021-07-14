/*!
    \file       IFraction.cs
    \brief      Contains an interface for a Fraction's functionality

    \author     Gem Aludino
    \date       14 July 2021
 */

/*!
    \namespace  GA
 */
namespace GA
{
    public interface IFraction
    { 
        void Set(int numerator, int denominator);

        Fraction Add(Fraction operand);
        Fraction Subtract(Fraction operand);
        Fraction Multiply(Fraction operand);
        Fraction Divide(Fraction operand);

        Fraction ChangeToReciprocal();
    }
}

