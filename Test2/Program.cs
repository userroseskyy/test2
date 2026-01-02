using System;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int rows1 = Convert.ToInt32(Console.ReadLine());
            int cols1 = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[rows1, cols1];

            int rows2 = Convert.ToInt32(Console.ReadLine());
            int cols2 = Convert.ToInt32(Console.ReadLine());

            int[,] B = new int[rows2, cols2];


            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.WriteLine($"A : [{i} ],[{j}]:");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.WriteLine($"B : [{i} ],[{j}]:");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            if (rows1 == rows2 && cols1 == cols2) { 
                Console.WriteLine("\n  jam:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write((A[i, j] + B[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }
            else
            {
                Console.WriteLine("\n jam emkanpazer");
            }






}
    





    }
}
