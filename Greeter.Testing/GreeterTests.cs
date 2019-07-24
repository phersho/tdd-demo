using Shouldly;

namespace Greeter.Testing
{
    public class GreeterTests
    {
        public void Test()
        {
            var greeter = new Greeter();
            greeter.ShouldNotBeNull();
        }
    }
}
