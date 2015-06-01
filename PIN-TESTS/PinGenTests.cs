using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinGenTests
    {
        [Test]
        public void Generate_should_retur_4_digit_number()
        {
            var pinGen = new PinGen();
            Assert.That(pinGen.Generate(), Is.EqualTo(1234));
        }
    }
}
