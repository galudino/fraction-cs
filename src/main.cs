/*!
    \file       main.cs
    \brief      Client source file for reading/computing operations with fractions

    \author     Gem Aludino
    \date       14 July 2021
 */

using static System.Console;

namespace GA
{
    public class FractionProgram
    {  
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("dat/input.dat");

            var divByZeroException = 0;
            var badArgumentException = 0;

            const int EXPECTED_COUNT = 20;
            var fractions = new Fraction[EXPECTED_COUNT];

            var fractionCount = 0;

            foreach (var line in lines)
            {
                var tokens = line.Split();

                if (tokens.Length != 2)
                {
                    continue;
                }

                var numerator = 0;
                var denominator = 1;

                var thrown = false;
                
                try 
                {
                    if (!int.TryParse(tokens[0], out numerator)) {
                        throw new System.ArgumentException();
                    }

                    if (!int.TryParse(tokens[1], out denominator)) {
                        throw new System.ArgumentException();
                    }

                    if (denominator == 0) {
                        throw new DivisionByZero();
                    }
                }
                catch (DivisionByZero e) 
                {
                    thrown = true;
                    ++divByZeroException;
                    WriteLine($"[Input: {line}]\n{e.Message}\n");
                }
                catch (System.ArgumentException e)
                {
                    thrown = true;
                    ++badArgumentException;
                    WriteLine($"[Input: {line}]\n{e.Message}\n");
                }

                if (!thrown) 
                {
                    fractions[fractionCount++] = new Fraction(numerator, denominator);
                }
            }

            var sb = new System.Text.StringBuilder();

            sb.Append($"\nFraction \tFloating-point form\n-----------------------------------\n");

            for (var i = 0; i < fractionCount; i++)
            {
                sb.Append($"{fractions[i]} \t{fractions[i].Decimal:0.000}\n");
            }

            sb.Append($"\nOperations\n-----------------------------------\n");
            sb.Append($"{fractions[0]} + {fractions[1]} = {fractions[0] + fractions[1]}\n");
            sb.Append($"{fractions[2]} - {fractions[3]} = {fractions[2] - fractions[3]}\n");
            sb.Append($"{fractions[4]} / {fractions[5]} = {fractions[4] / fractions[5]}\n");
            sb.Append($"{fractions[6]} * {fractions[7]} = {fractions[6] * fractions[7]}\n");
            sb.Append($"{fractions[8]} == {fractions[9]} = {fractions[8].Equals(fractions[9])}\n");
            sb.Append($"{fractions[1]} == {fractions[10]} = {fractions[1].Equals(fractions[10])}\n");
            sb.Append($"{fractions[2]} < {fractions[4]} = {fractions[2].Equals(fractions[4])}\n");
            sb.Append($"{fractions[4]} -> {fractions[4].ChangeToReciprocal()}\n"); 
            sb.Append($"\nDiagnostics\n-----------------------------------\n");
            sb.Append($"Total entries:     {lines.Length}\n\n");
            sb.Append($"DivisionByZero:    {divByZeroException} / {lines.Length}\n");
            sb.Append($"ArgumentException: {badArgumentException} / {lines.Length}\n");

            WriteLine(sb);
        }
    }
}
