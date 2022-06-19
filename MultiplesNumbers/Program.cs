using System;

namespace MultiplesNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialRangeValue = 1;
            int finiteRangeValue = 27;
            int initialNaturalNumber = 100;
            int finiteNaturalNumber = 999;
            int MultiplesNumbers;

            for (int i = initialRangeValue; i <= finiteRangeValue; i++)
            {
                MultiplesNumbers = 0;

                for (int j = i; j <= finiteNaturalNumber; j += i)
                {
                    if (j >= initialNaturalNumber)
                    {
                        MultiplesNumbers++;
                    }
                }

                Console.WriteLine($"N = {i} Кратных чисел: {MultiplesNumbers}");
            }
        }
    }
}
