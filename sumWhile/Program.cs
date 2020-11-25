using System;

namespace sumWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbers = 0;
            int evenNumbers = 0;

            Console.WriteLine("Введите первое число диапазона");

            int firstNumberRange = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");

            int secondNumberRange = int.Parse(Console.ReadLine());

            while (firstNumberRange<=secondNumberRange)
            {
                if ((firstNumberRange % 2)== 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }
                firstNumberRange++;
            }
            Console.WriteLine("Четных чисел" + evenNumbers);
            Console.WriteLine("Не четных чисел" + oddNumbers);
        }
    }
}
