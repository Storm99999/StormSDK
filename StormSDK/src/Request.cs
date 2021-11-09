using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StormSDK.src
{
    internal class Request
    {
        public enum REQUEST_TYPE
        {
            JSON_API,
            DEFAULT
        }
        public REQUEST_TYPE TYPE { get; set; }
        private HttpClient client;
        public void Set(REQUEST_TYPE type)
        {
            TYPE = type;
        }

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
