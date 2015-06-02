using Moq;
using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinPersistencePolicyTests
    {
        private Mock<FileSystemFacade> file_system;
        private PinPersistence pin_persistence;

        [SetUp]
        public void SetUp()
        {
            file_system = new Mock<FileSystemFacade>();
            pin_persistence = new PinPersistence(file_system.Object);
        }

        [Test]
        public void HasBeenGenerated_should_indicate_false_if_pin_is_stored()
        {
            file_system.Setup(o => o.IsPersisted(1234)).Returns(false);

            Assert.That(pin_persistence.HasBeenGenerated(1234), Is.False);
        }

        [Test]
        public void HasBeenGenerated_should_indicate_false_true_if_pin_is_not_stored()
        {
            file_system.Setup(o => o.IsPersisted(1234)).Returns(true);

            Assert.That(pin_persistence.HasBeenGenerated(1234), Is.True);
        }

        [Test]
        public void Constructor_should_ask_filesystem_facade_to_load_generated_pin_file()
        {
            file_system.Verify( o => o.LoadPins(It.IsAny<string>()), Times.Once);
        }
    }
}