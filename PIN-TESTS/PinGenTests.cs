using System.Globalization;
using System.Text.RegularExpressions;
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
            var pin = pinGen.Generate();

            string pattern = @"\d\d\d\d";
            var regex = new Regex(pattern);
            var matches = regex.Matches(pin.ToString(CultureInfo.InvariantCulture));

            Assert.That(matches.Count, Is.EqualTo(1));
        }

        [Test]
        public void Generate_should_return_random_4_digit_pin_number()
        {
            var pinGen = new PinGen();

            var first_pin = pinGen.Generate();
            var second_pin = pinGen.Generate();

            Assert.That(first_pin, Is.Not.EqualTo(second_pin));
        }
    }
}
