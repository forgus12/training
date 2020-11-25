using System;

namespace ArrayTwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y "+ i + " X "+ j);
                    myArray[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
