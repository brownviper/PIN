using System;

namespace PIN_GEN
{
    public class PinPersistencePolicy
    {
        private readonly FileSystemFacade file_system;

        public PinPersistencePolicy(FileSystemFacade file_system)
        {
            this.file_system = file_system;
        }

        public bool HasBeenGenerated(int pin)
        {
            var stored_pins = file_system.LoadPins();

            if (stored_pins.Contains(pin))
            {
                Console.WriteLine("*** Repeated Number: " + pin + " is rejected ***");
                return true;
            }

            return false;
        }

        public void Save(int pin)
        {
            file_system.SavePin(pin);
        }
    }
}