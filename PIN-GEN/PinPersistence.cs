namespace PIN_GEN
{
    public class PinPersistence
    {
        private readonly FileSystemFacade fileSystemFacade;

        public PinPersistence(FileSystemFacade fileSystemFacade)
        {
            this.fileSystemFacade = fileSystemFacade;
            this.fileSystemFacade.LoadPins("");
        }

        public bool HasBeenGenerated(int pin)
        {
            return fileSystemFacade.IsPersisted(pin);
        }
    }
}