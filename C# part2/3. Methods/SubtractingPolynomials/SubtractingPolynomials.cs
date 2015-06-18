//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficients of first polynomial separated by comma:");
            int[] polynomialOne = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Enter coefficients of second polynomial separated by comma:");
            int[] polynomialTwo = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
            int[] sum = SubtractPolynomials(polynomialOne, polynomialTwo);
            PrintPolynomial(sum);
        }

        static int[] SubtractPolynomials(int[] polyOne, int[] polyTwo)
        {
            int difference = Math.Abs(polyOne.Length - polyTwo.Length);
            if (polyOne.Length > polyTwo.Length)
            {
                int[] sum = new int[polyOne.Length];
                for (int i = 0; i < polyOne.Length; i++)
                {
                    if (i >= difference)
                    {
                        sum[i] = polyOne[i] - polyTwo[i - difference];
                    }
                    else
                    {
                        sum[i] = polyOne[i];
                    }
                }
                return sum;
            }
            else if (polyOne.Length < polyTwo.Length)
            {
                int[] sum = new int[polyTwo.Length];
                for (int i = 0; i < polyTwo.Length; i++)
                {
                    if (i >= difference)
                    {
                        sum[i] = polyTwo[i] - polyOne[i - difference];
                    }
                    else
                    {
                        sum[i] = polyTwo[i];
                    }
                }
                return sum;
            }
            else
            {
                int[] sum = new int[polyOne.Length];
                for (int i = 0; i < polyOne.Length; i++)
                {
                    sum[i] = polyOne[i] - polyTwo[i];
                }
                return sum;
            }
        }

        static void PrintPolynomial(int[] sum)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                if (i != sum.Length - 1 && sum[i] != 0)
                {
                    Console.Write("{0}x^{1} + ", sum[i], sum.Length - i - 1);
                }
                else if (i == sum.Length - 1)
                {
                    Console.Write("{0}", sum[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
