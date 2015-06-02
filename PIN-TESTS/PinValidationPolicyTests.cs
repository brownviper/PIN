using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinValidationPolicyTests
    {
        private PinValidationPolicy pin_validation;

        [SetUp]
        public void Setup()
        {
            pin_validation = new PinValidationPolicy();
        }

        [Test]
        public void ValidatePin_should_return_false_if_digits_are_the_same()
        {
            Assert.That(pin_validation.IsValidPin(1111), Is.False);
        }

        [Test]
        public void ValidatePin_should_return_ture_if_digits_are_not_the_same()
        {
            Assert.That(pin_validation.IsValidPin(1311), Is.True);
        }

    }
}