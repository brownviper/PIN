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
            file_system.Setup(o => o.LoadPins()).Returns(stored_pins);

            pin_persistence = new PinPersistence(file_system.Object);
        }


        [Test]
        public void HasBeenGenerated_should_ask_file_system_to_load_pins()
        {
            pin_persistence.HasBeenGenerated(7575);

            file_system.Verify(o => o.LoadPins(), Times.Once);
        }

        [Test]
        public void When_the_pin_is_not_stored_it_should_as_the_file_system_to_store_it()
        {
            file_system.Setup(o => o.LoadPins()).Returns(new int[] {});

            pin_persistence.HasBeenGenerated(7575);

            file_system.Verify(o => o.SavePin(7575), Times.Once);
        }
    }
}