using System;

namespace PIN_GEN
{
    public interface UserOutputController
    {
        void ShowPin(int pin);
    }

    public class ConsoleController : UserOutputController
    {
        public void ShowPin(int pin)
        {
            Console.WriteLine("Pin Generated --> " + pin);
        }
    }
}