namespace ConsoleApplication1.Extensibility
{
    public class Installer
    {
        private readonly ILogger _logger;

        public Installer(ILogger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.LogInfo("Install");
        }
    }
}