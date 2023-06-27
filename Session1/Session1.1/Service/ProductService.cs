
using Session1.Models;

namespace Session1.Service
{
    public class ProductService : IProductService
    {
        private readonly IConfiguration _configuration;

        public ProductService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetValue()
        {
            // Read value from appsettings.json
            string valueFromSettings = _configuration["AppSettingKey"];

            // Read value from environment variable
            string valueFromEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_MSG");

            return valueFromSettings + " | " + valueFromEnvironment;
        }    
    }
}
