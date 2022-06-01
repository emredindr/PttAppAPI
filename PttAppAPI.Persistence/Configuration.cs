using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace PttAppAPI.Persistence;
static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../PttAppAPI/PttAppAPI"));
            configurationManager.AddJsonFile("appsettings.json");
        
            return configurationManager.GetConnectionString("SqlServer");
        }
    }
}
