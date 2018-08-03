using System;
using Xunit;

namespace Kata02_KarateChop.Tests
{
    public abstract class KarateTest
    {
        public void ChopTest(IKarate karate)
        {
            Assert.Equal(-1, karate.Chop(3, new int[] { }));
            Assert.Equal(-1, karate.Chop(3, new[] {1}));
            Assert.Equal(0, karate.Chop(1, new[] {1}));
            Assert.Equal(0, karate.Chop(1, new[] {1, 3, 5}));
            Assert.Equal(1, karate.Chop(3, new[] {1, 3, 5}));
            Assert.Equal(2, karate.Chop(5, new[] {1, 3, 5}));
            Assert.Equal(-1, karate.Chop(0, new[] {1, 3, 5}));
            Assert.Equal(-1, karate.Chop(2, new[] {1, 3, 5}));
            Assert.Equal(-1, karate.Chop(4, new[] {1, 3, 5}));
            Assert.Equal(-1, karate.Chop(6, new[] {1, 3, 5}));
            Assert.Equal(0, karate.Chop(1, new[] {1, 3, 5, 7}));
            Assert.Equal(1, karate.Chop(3, new[] {1, 3, 5, 7}));
            Assert.Equal(2, karate.Chop(5, new[] {1, 3, 5, 7}));
            Assert.Equal(3, karate.Chop(7, new[] {1, 3, 5, 7}));
            Assert.Equal(-1, karate.Chop(0, new[] {1, 3, 5, 7}));
            Assert.Equal(-1, karate.Chop(2, new[] {1, 3, 5, 7}));
            Assert.Equal(-1, karate.Chop(4, new[] {1, 3, 5, 7}));
            Assert.Equal(-1, karate.Chop(6, new[] {1, 3, 5, 7}));
            Assert.Equal(-1, karate.Chop(8, new[] {1, 3, 5, 7}));
        }
    }
}