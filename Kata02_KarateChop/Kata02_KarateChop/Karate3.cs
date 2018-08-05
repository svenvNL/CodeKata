using System;

namespace Kata02_KarateChop
{
    public class Karate3 : IKarate
    {
        public int Chop(int number, int[] numbers)
        {
            if (numbers.Length > 0)
            {
                return Chop(number, numbers, 0);
            }

            return -1;
        }

        public int Chop(int number, int[] numbers, int index)
        {
            if (numbers[index] == number)
            {
                return index;
            }

            if (index + 1 <= numbers.Length - 1)
            {
                return Chop(number, numbers, index + 1);
            }

            return -1;
        }
    }
}