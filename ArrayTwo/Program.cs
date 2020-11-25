using System;
using System.Linq;

namespace ArrayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = rand.Next(0, 10);

            int sum =0;

            int comparison = myArray.Length;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]%2==0)
                {
                    Console.WriteLine(myArray[i]);
                    sum += myArray[i];
                }
                
                while (myArray[i]<comparison)
                {
                    comparison = myArray[i];
                }
                
            }
            Console.WriteLine(sum);
            Console.WriteLine(comparison);
        }
    }
}
