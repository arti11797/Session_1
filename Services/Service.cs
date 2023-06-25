using Session_1.Interface;

namespace Session_1.Services
{
   
        public class Service : IServices
        {
            readonly IConfiguration _configuration;

            public Service(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            public string GetValue(string key)
            {
                return _configuration.GetValue<string>(key);
            }
        }

    }

