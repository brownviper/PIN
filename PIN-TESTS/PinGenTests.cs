using System.Globalization;
using System.Text.RegularExpressions;
using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinGenTests
    {
        private PinGen pin_gen;

        [SetUp]
        public void Setup()
        {
            pin_gen = new PinGen();
        }

        [Test]
        public void Generate_should_return_4_digit_number()
        {
            var pin = pin_gen.Generate();

            const string pattern = @"\d\d\d\d";
            var regex = new Regex(pattern);
            var matches = regex.Matches(pin.ToString(CultureInfo.InvariantCulture));

            Assert.That(matches.Count, Is.EqualTo(1));
        }

        [Test]
        public void Generate_should_return_random_4_digit_pin_number()
        {
            var first_pin = pin_gen.Generate();
            var second_pin = pin_gen.Generate();

            Assert.That(first_pin, Is.Not.EqualTo(second_pin));
        }
    }
}
