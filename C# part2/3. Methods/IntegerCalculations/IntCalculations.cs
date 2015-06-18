//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by comma: ");
        int[] array = Console.ReadLine().Trim().Split(',').Select(s => int.Parse(s)).ToArray();
        int min = new int();
        int max = new int();
        decimal average = new decimal();
        int sum = new int();
        int product = new int();
        min = FindMin(array);
        max = FindMax(array);
        average = FindAverage(array);
        sum = FindSum(array);
        product = FindProduct(array);
        Console.WriteLine("The minimum is: {0}", min);
        Console.WriteLine("The maximum is: {0}", max);
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The product is: {0}", product);
        Console.WriteLine("The average is: {0}", average);

    }

    static int FindSum(int[] array)
    {
        int sum = new int();
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int FindProduct(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static int FindMin(int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int FindMax(int[] array)
    {
        int max = new int();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static decimal FindAverage(int[] array)
    {
        decimal average = new decimal();
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average /= array.Length;
        return average;
    }
}
