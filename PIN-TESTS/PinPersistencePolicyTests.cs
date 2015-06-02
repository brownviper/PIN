using System;
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
        private int[] stored_pins;

        [SetUp]
        public void SetUp()
        {
            stored_pins = new[] { 1234, 5678, 9101 };
            
            file_system = new Mock<FileSystemFacade>();
            file_system.Setup(o => o.LoadPins(It.IsAny<String>())).Returns(stored_pins);

            pin_persistence = new PinPersistence(file_system.Object);
        }


        [Test]
        public void HasBeenGenerated_should_return_true_if_pin_is_stored()
        {
            Assert.That(pin_persistence.HasBeenGenerated(5678), Is.True);
            file_system.Verify(o => o.LoadPins(It.IsAny<String>()), Times.Once);
        }

        [Test]
        public void HasBeenGenerated_should_return_falas_if_pin_is_not_stored()
        {
            Assert.That(pin_persistence.HasBeenGenerated(7575), Is.False);
            file_system.Verify(o => o.LoadPins(It.IsAny<String>()), Times.Once);
        }

        [Test]
        public void HasBeenGenerated_should_return_false_if_no_pin_is_stored()
        {
            file_system.Setup(o => o.LoadPins(It.IsAny<String>())).Returns(new int[]{});

            Assert.That(pin_persistence.HasBeenGenerated(5678), Is.False);
            file_system.Verify(o => o.LoadPins(It.IsAny<String>()), Times.Once);
        }

        [Test]
        public void When_the_pin_is_not_stored_it_should_as_the_file_system_to_store_it()
        {
            
        }
    }
}