using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Http
{
    public class Connection
    {
        private HttpClient? httpClient;

        public HttpClient Conn()
        {
            httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            return httpClient;
        }
        
    }
}
