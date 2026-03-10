using System;
class Program
{
    static void Main()
    {
        int[,] arr1 = { {1,2,3 },{4,5,6 },{7,8,9 } };
        int[,] arr2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        int[,] arr3 = new int[3, 3];
        Console.WriteLine("matrix 1:");
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
                Console.Write(arr1[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("matrix 2");
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
                Console.Write(arr2[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("multiplication");
        for (int i=0; i<arr3.GetLength(0); i++)
        {
            for(int j=0; j<arr3.GetLength(1); j++)
            {
                arr3[i, j] = arr1[i, j] * arr2[i, j];
                Console.Write(arr3[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
}