using FluentAssertions;

namespace reactTest.Tests
{
    /// <summary>
    /// sadsakdaskdmaskmdas<br></br>
    /// askdnaskdalda
    /// <code>ssssssss</code>
    /// </summary>
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            reactTest.Server.Target.doSomething().Should().BeTrue();
        }
    }
}