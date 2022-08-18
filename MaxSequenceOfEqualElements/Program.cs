using System;
using System.Linq;
namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToArray();
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eihght = 0;
            int nine = 0;
            int zero = 0;
            int sum = 0;
            int maxSum = int.MinValue;
            int result = 0;
            int numberinRange = 0;
            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num == 0)
                {
                    zero++;
                    sum = zero;
                    numberinRange = 0;
                }
                else
                {
                    zero = 0;
                }
                if (num == 1)
                {
                    one++;
                    sum = one;
                    numberinRange = 1;
                }
                else
                {
                    one = 0;
                }
                if (num == 2)
                {
                    two++;
                    sum = two;
                    numberinRange = 2;
                }
                else
                {
                    two = 0;
                }
                if (num == 3)
                {
                    three++;
                    sum = three;
                    numberinRange = 3;
                }
                else
                {
                    three = 0;
                }
                if (num == 4)
                {
                    four++;
                    sum = four;
                    numberinRange = 4;
                }
                else
                {
                    four = 0;
                }
                if (num == 5)
                {
                    five++;
                    sum = five;
                    numberinRange = 5;
                }
                else
                {
                    five = 0;
                }
                if (num == 6)
                {
                    six++;
                    sum = six;
                    numberinRange = 6;
                }
                else
                {
                    six = 0;
                }
                if (num == 7)
                {
                    seven++;
                    sum = seven;
                    numberinRange = 7;
                }
                else
                {
                    seven = 0;
                }
                if (num == 8)
                {
                    eihght++;
                    sum = eihght;
                    numberinRange = 8;
                }
                else
                {
                    eihght = 0;
                }
                if (num == 9)
                {
                    nine++;
                    sum = nine;
                    numberinRange = 9;
                }
                else
                {
                    nine = 0;
                }
                result += sum;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    number = numberinRange;
                }
            }
            for (int l = 0; l < maxSum; l++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
