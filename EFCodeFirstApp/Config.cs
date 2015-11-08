using System.Configuration;

namespace EFCodeFirstApp
{
    public sealed class Config
    {
        public static string ConnectionString { get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }
    }
}