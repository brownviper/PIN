using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinGenTests
    {
        [Test]
        public void Generate_should_return_a_number()
        {
            var pinGen = new PinGen();
            int number = pinGen.Generate();

            Assert.That(number, Is.EqualTo(0));
        }
    }
}
