using System;
using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public class Greeter : IGreeter
    {
        private readonly IConfiguration _configuration;
        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessage()
        {
            return "Greetings!";
        }
    }
}
