using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritinsuranceAPI.Tests
{
    internal class ApiTests
    {

        public static RestClient GetClient()
        {
            var client = new RestClient("https://api.restful-api.dev/");
            return client;
        }
    }
}
