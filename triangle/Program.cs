using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int k = 0; k < height; k++)
            {
                for (int w = height; w > k; w--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int q = 0; q <= height; q++)
            {
                for (int e = height; e > q; e--)
                {
                    Console.Write(" ");
                }

                for (int e = 0; e < q; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            
            for (int k = 0; k < height; k++)
            {
                for (int e = 0; e < k; e++)
                {
                    Console.Write(" ");
                }

                for (int w = height; w > k; w--)
                {
                    Console.Write("*");
                }

                
                Console.WriteLine("");
            }
        }
    }
}
