using System;
using System.Linq;

namespace _5._TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputArr.Length; i++)
            {
                bool currIterationNumIsBigger = true;
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        currIterationNumIsBigger = false;
                    }
                }
                if (currIterationNumIsBigger)
                {
                    Console.Write($"{inputArr[i]} ");
                }
            }
        }
    }
}
