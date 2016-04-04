using Microsoft.Extensions.Configuration;

namespace Tee.FamilyApp.Web.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly IConfiguration _greeter;

        public GreetingService(IConfiguration configuration)
        {
            _greeter = configuration;
        }

        public string GetGreeting()
        {
            //return "Hello from the greeting service";
            return _greeter["greeting"];
        }
    }
}