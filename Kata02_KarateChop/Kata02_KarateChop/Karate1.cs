namespace Kata02_KarateChop
{
    public class Karate1 : IKarate
    {
        public int Chop(int number, int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}