using System.Collections.Generic;

namespace PIN_GEN
{
    public interface FileSystemFacade
    {
        List<int> LoadPins();
        void SavePin(int pin);
    }
}