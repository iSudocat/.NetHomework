using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵。
 *给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。
 */
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            {
                new int[]  { 1,2,3,4 },
                new int[]  { 5,1,2,3 },
                new int[]  { 9,5,1,2 }
            };
            Console.WriteLine(isToeplitzMatrix(matrix));
            Console.ReadLine();
        }

        public static bool isToeplitzMatrix(int[][] matrix)
        {
            for (int r = 0; r < matrix.Length; r++)
                for (int c = 0; c < matrix[0].Length; c++)
                    if (r > 0 && c > 0 && matrix[r - 1][c - 1] != matrix[r][c])
                        return false;
            return true;
        }


    }
}
