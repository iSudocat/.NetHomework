using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
 */

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 24, 9, 6, 2, 8, 13, 7, 19 };
            Console.WriteLine("最大值" + Max(a));
            Console.WriteLine("最小值" + Min(a));
            Console.WriteLine("和" + Sum(a));
            Console.WriteLine("平均值" + Average(a));
            Console.ReadLine();
        }

        private static int Max(int[] a)
        {
            int max = a[0];
            foreach (int x in a)
            {
                if (x > max)
                {
                    max = x;
                }
            }
            return max;
        }

        private static int Min(int[] a)
        {
            int min = a[0];
            foreach (int x in a)
            {
                if (x < min)
                {
                    min = x;
                }
            }
            return min;
        }

        private static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
            {
                sum += x;
            }
            return sum;
        }

        private static double Average(int[] a)
        {
            double sum = 0;
            foreach (int x in a)
            {
                sum += x;
            }
            double average = sum / a.Length;
            return average;
        }
    }
}
