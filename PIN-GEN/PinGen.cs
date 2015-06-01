using System;
using System.Security.Cryptography;

namespace PIN_GEN
{
    public class PinGen
    {
        private Random random;

        public PinGen()
        {
            random = new Random();
        }

        public int Generate()
        {
            return random.Next(1000, 9999);
        }
    }
}