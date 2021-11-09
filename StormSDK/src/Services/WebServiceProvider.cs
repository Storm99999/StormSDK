using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace StormSDK.src.Services
{
    internal class WebServiceProvider : Service
    {
        public SERVICE_TYPE _service { get; set; }
        public bool _showLog { get; set; }

        public WebServiceProvider(bool showLog)
        {
            _service = SERVICE_TYPE.WEB;
            _showLog = showLog;
            if (_showLog)
            {
                MessageBox.Show("SERVICE TYPE IS WEB");
            }
        }

        public static void FGET(string url, string path)
        {
            new WebClient().DownloadFile(url, path);
        }

        public static void GETreq(string url)
        {
            
        }
    }
}
