using Xunit;

namespace Kata02_KarateChop.Tests
{
    public class Karate2Tests : KarateTest
    {
        [Fact]
        public void Chop()
        {
            ChopTest(new Karate2());
        }
    }
}