using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using PIN_GEN;

namespace PIN_TESTS
{
    [TestFixture]
    public class PinPersistencePolicyTests
    {
        private Mock<FileSystemFacade> file_system;
        private PinPersistencePolicy pin_persistence;
        private List<int> stored_pins;

        [SetUp]
        public void SetUp()
        {
            stored_pins = new List<int>{1234, 5678, 9101};

            file_system = new Mock<FileSystemFacade>();
            file_system.Setup(o => o.LoadPins()).Returns(stored_pins);

            pin_persistence = new PinPersistencePolicy(file_system.Object);
        }


        [Test]
        public void HasBeenGenerated_should_ask_file_system_to_load_pins()
        {
            pin_persistence.HasBeenGenerated(7575);

            file_system.Verify(o => o.LoadPins(), Times.Once);
        }

        [Test]
        public void HasBeenGenerated_should_return_false_when_no_pins_are_available()
        {
            file_system.Setup(o => o.LoadPins()).Returns(new List<int>());

            Assert.That(pin_persistence.HasBeenGenerated(7575), Is.EqualTo(false));
        }


        [Test]
        public void HasBeenGenerated_should_return_false_when_generated_pin_is_new()
        {
            Assert.That(pin_persistence.HasBeenGenerated(7575), Is.EqualTo(false));
        }

        [Test]
        public void HasBeenGenerated_should_return_true_when_pin_already_exist()
        {
            Assert.That(pin_persistence.HasBeenGenerated(9101), Is.EqualTo(true));
        }

        [Test]
        public void Save_should_pass_pin_to_file_system()
        {
            pin_persistence.Save(5932);

            file_system.Verify(o => o.SavePin(5932), Times.Once);
       }
    }
}