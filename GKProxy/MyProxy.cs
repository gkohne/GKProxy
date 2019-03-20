using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace GKProxy
{
    public static class MyProxy
    {
        public static List<string> _list = new List<string>();
        static ProxyOutput _proxyOutput = new ProxyOutput();

        public static void Start()
        {
            var proxyServer = new ProxyServer();

            proxyServer.BeforeRequest += OnRequest;
            proxyServer.BeforeResponse += OnResponse;

            var endPoint = new ExplicitProxyEndPoint(IPAddress.Any, 8080);
            proxyServer.AddEndPoint(endPoint);
            proxyServer.Start();
        }


        public static async Task OnRequest(object sender, SessionEventArgs e)
        {
            _list.Add("Request : " + e.HttpClient.Request);
           // _proxyOutput.backgroundWorkerUpdateProxyOutput.RunWorkerAsync();
        }

        public static async Task OnResponse(object sender, SessionEventArgs e)
        {
            _list.Add("Responce : " + e.HttpClient.Response);
            //_proxyOutput.backgroundWorkerUpdateProxyOutput.RunWorkerAsync();
        }


    }
}
