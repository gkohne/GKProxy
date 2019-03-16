using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace GKProxy
{
    public class MyProxy
    {
        List<string> list = new List<string>();
        ProxyOutput proxyOutput = new ProxyOutput();

        public MyProxy()
        {
            var proxyServer = new ProxyServer();

            proxyServer.BeforeRequest += OnRequest;
            proxyServer.BeforeResponse += OnResponse;

            var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Any, 8080);

            //An explicit endpoint is where the client knows about the existence of a proxy
            //So client sends request in a proxy friendly manner
            proxyServer.AddEndPoint(explicitEndPoint);
            proxyServer.Start();

            //Transparent endpoint is useful for reverse proxy (client is not aware of the existence of proxy)
            //A transparent endpoint usually requires a network router port forwarding HTTP(S) packets or DNS
            //to send data to this endPoint
            //var transparentEndPoint = new TransparentProxyEndPoint(IPAddress.Any, 8001, true)
            //{
            //Generic Certificate hostname to use
            //when SNI is disabled by client
            //    GenericCertificateName = "google.com"
            //};

            //proxyServer.AddEndPoint(transparentEndPoint);

            //Unsubscribe & Quit
            //proxyServer.BeforeRequest -= OnRequest;
            //proxyServer.BeforeResponse -= OnResponse;
    }

        public async Task OnRequest(object sender, SessionEventArgs e)
        {
            list.Add("Request : " + e.WebSession.Request.ToString());
            UpdateTextbox();
            //e.WebSession.Request.Headers.AddHeader("Ab", "Moo");

            //var headers = e.WebSession.Request.Headers.GetAllHeaders();

            //var ordered = headers.OrderBy(x => x.Name);

            //e.WebSession.Request.Headers.Clear();

            //foreach (var httpHeader in ordered)
            //{
            //    e.WebSession.Request.Headers.AddHeader(httpHeader);
            //}

        }

        public async Task OnResponse(object sender, SessionEventArgs e)
        {
            list.Add("Responce : " + e.WebSession.Response.ToString());
            UpdateTextbox();
        }

        public void Get()
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                Proxy = new WebProxy($"http://localhost:8080", false),
                UseProxy = true,
            };

            HttpClient client = new HttpClient(handler);
            var t = 
            Task.Run(() => GetDataAsync(client, "https://google.com/"));
            t.Wait();
            var result = t.Result;
            list.Add(result);
            proxyOutput.Show();
        }

        static async Task<string> GetDataAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }

        void UpdateTextbox()
        {
            //StringBuilder builder = new StringBuilder();
            //foreach (string item in list)
            //{
            //    builder.Append(item.Substring(0)).AppendLine();
            //}

            proxyOutput.listBoxOutput.DataSource = null;
            proxyOutput.listBoxOutput.DataSource = list;
            proxyOutput.labelCountvalue.Text = list.Count.ToString();

        }
    }
}
