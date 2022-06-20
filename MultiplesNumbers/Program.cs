using System;

namespace MultiplesNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int initialRangeValue = 1;
            int finiteRangeValue = 28;
            int initialNaturalNumber = 100;
            int finiteNaturalNumber = 999;
            int randomNumber;
            int divisible = 0;

            randomNumber = random.Next(initialRangeValue, finiteRangeValue);


            for (int i = randomNumber; i <= finiteNaturalNumber; i += randomNumber)
            {
                if (i >= initialNaturalNumber)
                {
                    divisible++;
                }
            }

            Console.WriteLine($"Количество чисел в диапозоне от : {initialNaturalNumber} до : {finiteNaturalNumber} на которое делится N {randomNumber} состовляет {divisible}");
        }
    }
}
