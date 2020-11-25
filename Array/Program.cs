using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов вы хотите добавить в массив?");
            int a = int.Parse(Console.ReadLine());
            int[] myArray=new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введи элемент массива");
                int elem = int.Parse(Console.ReadLine());
                myArray[i] = elem;
            }


            for (int i = myArray.Length - 1 ; i >= 0 ; i--)
            {
                Console.Write(myArray[i]);
            }
        }
    }
}
