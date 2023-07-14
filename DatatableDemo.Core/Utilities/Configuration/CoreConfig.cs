using System.Configuration;

namespace DatatableDemo.Core.Utilities.Configuration
{
    public static class CoreConfig
    {
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetConnectionString(string connection)
        {
            return ConfigurationManager.ConnectionStrings[connection].ConnectionString;
        }
    }
}
