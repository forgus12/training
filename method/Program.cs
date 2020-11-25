using System;

namespace method
{
    class Program
    {
        static void Print(string symbol,int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine(symbol);
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ(-ы) который(-е) хотите вывести");
            string sym= Console.ReadLine();
            Console.WriteLine("Введите сколько раз вы хотите вывести ");
            int num = int.Parse(Console.ReadLine());
            Print(sym, num);
        }
    }
}
