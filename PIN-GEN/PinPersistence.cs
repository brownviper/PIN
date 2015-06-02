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

        public void HasBeenGenerated(int pin)
        {
            var stored_pins = file_system.LoadPins();

            if ( !stored_pins.Contains(pin) )
            {
                file_system.SavePin(pin);
            }
        }
    }
}