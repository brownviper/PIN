using System;

namespace PIN_GEN
{
    public class DiskFileSystem : FileSystemFacade
    {
        private string file_name;

        DiskFileSystem(String file_name)
        {
            this.file_name = file_name;
        }

        public int[] LoadPins()
        {
            return new[] {1234};
        }

        public void SavePin(int pin)
        {
            
        }
    }
}