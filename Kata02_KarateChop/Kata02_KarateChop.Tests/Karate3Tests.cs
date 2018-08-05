using Xunit;

namespace Kata02_KarateChop.Tests
{
    public class Karate3Tests : KarateTest
    {
        [Fact]
        public void Chop()
        {
            ChopTest(new Karate3());
        }
    }
}