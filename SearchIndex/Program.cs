using System;

namespace SearchIndex
{
    class Program
    {

        static int SearchIn(int[] arr,int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==a)
                {
                    return i;
                }
            }
            return -1;
        }
        
        
        static void Main(string[] args)
        {
            int[] myArray = { 1, 15, 3, 42, 515, 42 };
            Console.WriteLine(SearchIn(myArray, 5));
        }
    }
}
