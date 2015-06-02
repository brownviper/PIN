using System;

namespace PIN_GEN
{
    public class DiskFileSystem : FileSystemFacade
    {
        public int[] LoadPins(String file_name)
        {
            return new[] {1234};
        }
    }
}