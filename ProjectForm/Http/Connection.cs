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
            //string portFilePath = @"C:\Temp\port.txt";

            //int retries = 0;
            //while (!File.Exists(portFilePath) && retries < 10)
            //{
            //    Thread.Sleep(500); 
            //    retries++;
            //}

            //if (!File.Exists(portFilePath))
            //    throw new Exception("Could not find port.txt. Is the API running?");

            //int port = int.Parse(File.ReadAllText(portFilePath));

            httpClient = new HttpClient
            {
                //BaseAddress = new Uri($"http://localhost:{port}/api")
                BaseAddress = new Uri($"https://localhost:7014/api")
            };
        }
        public static HttpClient Instance => httpClient;
    }
}
