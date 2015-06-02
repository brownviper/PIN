namespace PIN_GEN
{
    public class DiskFileSystem : FileSystemFacade
    {
        public bool IsPersisted(int pin)
        {
            return false;
        }
    }
}