using System;
using System.Collections.Generic;
using System.IO;

namespace PIN_GEN
{
    public class DiskFileSystem : FileSystemFacade
    {
        private string file_name;

        public DiskFileSystem(String file_name)
        {
            this.file_name = file_name;
        }

        public List<int> LoadPins()
        {
            var pins = new List<int>();

            if (!File.Exists(file_name))
                using(File.Create(file_name)){}

            using (var pin_reader = new StreamReader(file_name))
            {
                String pin;

                while ((pin = pin_reader.ReadLine()) != null)
                {
                    pins.Add(Convert.ToInt32(pin));
                }
            }

            return pins;
        }

        public void SavePin(int pin)
        {
            using (var pin_writer = new StreamWriter(file_name, true))
            {
                pin_writer.WriteLine(Convert.ToString(pin));
            }
            
        }
    }
}