using FluentAssertions;

namespace reactTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            reactTest.Server.Target.doSomething().Should().BeTrue(); //w
        }
    }
}
