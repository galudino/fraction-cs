/*!
    \file       DivisionByZero.cs
    \brief      Exception class for a division-by-zero error

    \author     Gem Aludino
    \date       14 July 2021
 */

namespace GA
{
    public class DivisionByZero : System.Exception
    {
        public DivisionByZero() { }

        public DivisionByZero(string message)
            : base(string.Format("DivisionByZero: {0}", message)) { }
    }
}

