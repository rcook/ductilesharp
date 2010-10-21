using NUnit.Framework;

namespace Mono.DuctileSharp
{
    [TestFixture]
    public sealed class AddInTest
    {
        [Test]
        public void DoSomething()
        {
            AddIn addIn = new AddIn();
            addIn.DoSomething();
        }
    }
}

