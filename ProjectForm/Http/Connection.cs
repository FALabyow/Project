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
            int port = int.Parse(File.ReadAllText("port.txt"));
            httpClient = new HttpClient
            {
                //BaseAddress = new Uri("https://localhost:7014/api")
                BaseAddress = new Uri($"http://localhost:{port}/api")
            };
        }
        public static HttpClient Instance => httpClient;
    }
}
