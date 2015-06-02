namespace PIN_GEN
{
    public class PinPersistence
    {
        private readonly FileSystemFacade fileSystemFacade;

        public PinPersistence(FileSystemFacade fileSystemFacade)
        {
            this.fileSystemFacade = fileSystemFacade;
        }

        public bool HasBeenGenerated(int pin)
        {
            return fileSystemFacade.IsPersisted(pin);
        }
    }
}