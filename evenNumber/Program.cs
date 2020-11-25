using System;

namespace evenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;

            Console.WriteLine("Введите число");

            a = int.Parse(Console.ReadLine());

            if ((a/2)==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
