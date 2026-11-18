using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class HelloServices : IHelloServices
    {

        public string SayHello(string name)
        {
            string realName = $"Hello, {name}!";
            return realName;
        }
    }
}