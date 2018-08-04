using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata02_KarateChop
{
    public class Karate2 : IKarate
    {
        public int Chop(int number, int[] numbers)
        {
            // Handle case array has 0 or 1 value
            switch (numbers.Length)
            {
                case 0:
                    return -1;
                case 1 when numbers[0] == number:
                    return 0;
                case 1:
                    return -1;
            }

            if (numbers[numbers.Length - 1] < number)
            {
                return -1;
            }
            
            if (numbers[0] > number)
            {
                return -1;
            }

            var indexLeft = 0;
            var indexRight = 0;
            var toFindIn = numbers;
            var findingInLeft = true;

            while (true)
            {
                var splitted = SplitArray(toFindIn.ToList());

                if (!findingInLeft)
                {
                    indexLeft += indexRight + splitted.left.Count - 1;
                    indexRight += splitted.left.Count;
                }
                else
                    indexRight = splitted.left.Count;

                if (splitted.left.Count == 1 && splitted.left.Contains(number))
                    return indexLeft;

                if (splitted.right.Count == 1 && splitted.right.Contains(number))
                    return indexRight;

                if (splitted.left.Count == 1 && splitted.right.Count == 1)
                    return -1;

                if (splitted.right.First() > number)
                {
                    toFindIn = splitted.left.ToArray();
                    findingInLeft = true;
                }
                else
                {
                    toFindIn = splitted.right.ToArray();
                    findingInLeft = false;
                }
            }
        }

        private (List<T> left, List<T> right) SplitArray<T>(List<T> list)
        {
            var splitIndex = Convert.ToInt32(Math.Round(list.Count / 2.0));

            return (
                list.GetRange(0, splitIndex),
                list.GetRange(splitIndex, list.Count - splitIndex)
            );
        }
    }
}