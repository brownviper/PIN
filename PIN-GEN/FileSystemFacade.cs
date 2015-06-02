namespace PIN_GEN
{
    public interface FileSystemFacade
    {
        int[] LoadPins();
        void SavePin(int pin);
    }
}