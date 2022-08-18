using System;
using System.Linq;
namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(separator: " ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = 0;
                    sum = arr[j] + numbers[i];
                    if (arr[i] + numbers[j] == magicNum)
                    {
                        Console.WriteLine($"{arr[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}

