using System;
using System.Diagnostics;
using System.Linq;

namespace PIN_GEN
{
    public class PinValidationPolicy
    {
        public bool IsValidPin(int pin)
        {
            var number = pin.ToString();
            var count = number.Count(c => c == number[0]);

            return  count != 4;
        }
    }
}