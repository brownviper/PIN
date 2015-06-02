using System;

namespace PIN_GEN
{
    public interface PinGenOutputController
    {
        void ShowPin(int pin);
    }

    public class ConsoleController : PinGenOutputController
    {
        public void ShowPin(int pin)
        {
            Console.WriteLine("New Pin Generated ---------> " + pin);
        }

        public void Play()
        {

            var pin_gen = new PinGen();
            var persistence = new PinPersistencePolicy(new DiskFileSystem("pins.txt"));
            var validation = new PinValidationPolicy();


            ConsoleKeyInfo key_info;

            do
            {
                ShowHelpMessage();

                key_info = Console.ReadKey();

                if (key_info.Key == ConsoleKey.Escape)
                    break;

                var pin = pin_gen.Generate();

                if (validation.IsValidPin(pin) && !persistence.HasBeenGenerated(pin))
                {
                    persistence.Save(pin);
                    ShowPin(pin);
                }

            } while (true);
        }

        private static void ShowHelpMessage()
        {
            Console.WriteLine("Press any key to generate new Pin or <Esc> to exit");
        }
    }
}