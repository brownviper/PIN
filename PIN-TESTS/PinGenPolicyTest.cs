using Moq;
using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinGenPolicyTest
    {
        [Test]
        public void hasBeenGenerated_should_indicate_true_if_pin_is_stored()
        {
            var file_system = new Mock<FileSystemFacade>();
            file_system.Setup(o => o.IsPersisted(1234)).Returns(false);

            var pinPersistence = new PinPersistence( file_system.Object );

            var hasBeenGenerated = pinPersistence.HasBeenGenerated(1234);

            Assert.That(hasBeenGenerated, Is.False);
        }
    }
}