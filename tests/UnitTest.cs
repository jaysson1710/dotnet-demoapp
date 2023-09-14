using Xunit;
using DotnetDemoapp;

namespace DotnetDemoapp_tests
{
    public class LameUnitTest1
    {
        [Fact]
        public void TestAThingFalse()
        {
            bool result = false;
            Assert.False(result, $"{result} should not be true");
        }
    }

    public class LameUnitTest2
    {
        [Fact]
        public void TestAThingTrue()
        {
            bool result = true;
            Assert.True(result, $"{result} should not be false");
        }
    }

    public class class1Test
    {
        [Fact]
        public void test1()
        {
            var instancia = new class1(1);

            Assert.Equal(instancia.numero, 1);
        }
    }
}
