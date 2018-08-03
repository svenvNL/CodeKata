using System;
using Xunit;

namespace Kata02_KarateChop.Tests
{
    public class Karate1Test : KarateTest
    {
        [Fact]
        public void Chop()
        {
            ChopTest(new Karate1());
        }
    }
}