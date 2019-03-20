using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace GKProxy
{
    public static class MyProxy
    {
        public static List<string> _list = new List<string>();

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
            _list.Add(e.HttpClient.Request.ToString());
        }

        public static async Task OnResponse(object sender, SessionEventArgs e)
        {
            _list.Add(e.HttpClient.Response.ToString());
        }


    }
}
