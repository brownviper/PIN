namespace PIN_GEN
{
    public interface FileSystemFacade
    {
        bool IsPersisted(int pin);
        void LoadPins(string file_name);
    }
}