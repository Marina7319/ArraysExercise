using System;

namespace _2._CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Hey, hello, 2, 4]
            string[] arrOne = Console.ReadLine().Split(separator: ' ');
            //[10, hey, 4, hello]
            string[] arrTwo = Console.ReadLine().Split(separator: ' ');
            foreach (string currElement in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string secondCurrElement = arrOne[i];
                    if (currElement == secondCurrElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }
        }
    }
}
