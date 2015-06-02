using System;

namespace PIN_GEN
{
    public class PinPersistence
    {
        private readonly FileSystemFacade file_system;

        public PinPersistence(FileSystemFacade file_system)
        {
            this.file_system = file_system;
        }

        public bool HasBeenGenerated(int pin)
        {
            var stored_pins = file_system.LoadPins("");
            var index = Array.IndexOf(stored_pins, pin);

            return index != -1;
        }
    }
}