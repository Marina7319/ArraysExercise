using System;
using System.Linq;


namespace _3._Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenArray = new int[lines];
            int[] oddArray = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[0];
                }
                if (i % 2 != 0)
                {
                    oddArray[i] = numbers[1];
                }
                else
                {
                    oddArray[i] = numbers[0];
                }
            }
            for (int j = 0; j < lines; j++)
            {
                Console.Write(oddArray[j] + " ");
            }
            Console.WriteLine();
            for (int l = 0; l < lines; l++)
            {
                Console.Write(evenArray[l] + " ");
            }
        }
    }
}
