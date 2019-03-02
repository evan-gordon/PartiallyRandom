using System;
using Xunit;
using PRand;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void RandNotInList()
        {
            SemiRand rn = new SemiRand();
            for(int i = 0; i < 10; i++) {
                int r = rn.NextInt(2, new[] {1});
                Assert.Equal(r, 0);
            }
        }

        [Fact]
        public void ExceptionOccurs()
        {
            SemiRand rn = new SemiRand();
            var except = Record.Exception(() => rn.NextInt(-1, new[] {0,1}));
            Assert.NotNull(except);
            Assert.IsType<ArgumentOutOfRangeException>(except);
        }
    }
}
