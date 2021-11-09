using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StormSDK.src.Services
{
    internal class RequestServiceProvider : Request
    {
        private HttpClient client;
        public async Task GET(string url, string parsedStr)
        {
            if (TYPE == REQUEST_TYPE.JSON_API)
            {
                parsedStr = new WebClient().DownloadString(url);
            }
            else
            {
                if (TYPE == REQUEST_TYPE.DEFAULT)
                {
                    client = new HttpClient();
                    parsedStr = await client.GetStringAsync(url);
                }
            }
        }
    }
}
