// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //假设所给矩阵
            int[,] matrix = {
                { 1, 2, 3, 4 },
                { 5, 1, 2, 3 },
                { 9, 5, 1, 2 }
            };

            bool isToeplitz = IsToeplitzMatrix(matrix);
            //比if更加简洁
            Console.WriteLine(isToeplitz ? "这是一个托普利茨矩阵" : "这不是一个托普利茨矩阵");
        }

        static bool IsToeplitzMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0); // 获取矩阵的行数（第一维的长度）
            int cols = matrix.GetLength(1); // 获取矩阵的列数（第二维的长度

            for (int i = 1; i < rows; i++) // 从第1行开始
            {
                for (int j = 1; j < cols; j++) // 从第1列开始
                {
                    // 检查当前元素是否与其左上方的元素相同
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
