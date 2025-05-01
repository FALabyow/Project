using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Http
{
    public static class Connection
    {
        private static readonly HttpClient httpClient;

        static Connection()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7014/api/")
            };
        }

        public static HttpClient Instance => httpClient;
    }
}
