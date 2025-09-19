using Xunit;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class GreeterTests
    {
        [Fact]
        public void SayHello_ReturnsHelloWorld()
        {
            var greeter=new Greeter();

            Assert.Equal("Hello, World!", greeter.SayHello());

        }
    }
}