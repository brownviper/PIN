using System;

namespace PIN_GEN
{
    public interface FileSystemFacade
    {
        int[] LoadPins(String file_name);
    }
}