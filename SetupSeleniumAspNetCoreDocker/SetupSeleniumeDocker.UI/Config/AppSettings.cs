using Microsoft.Extensions.Options;

namespace SetupSeleniumeDocker.UI.Config
{
    public class AppSettings : IAppSettings
    {
        private readonly IOptions<ConnectionStrings> _connectionString;

        public AppSettings(IOptions<ConnectionStrings> connectionString)
        {
            _connectionString = connectionString;
        }

        public ConnectionStrings GetConnectionStrings()
        {
            return _connectionString.Value;
        }
    }
}