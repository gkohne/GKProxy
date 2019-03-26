using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace MyProxy
{
    public static class TheProxy
    {
        //private static readonly SemaphoreSlim _lock = new SemaphoreSlim(1);
        public static List<string> _list = new List<string>();
        static ProxyServer proxyServer = new ProxyServer(true,true,true);

        public static void Start()
        {
            string certName = "rootCert.pfx";
            string certPassword = "Password";

            //Console.WriteLine("Starting Proxy ...");

            //proxyServer.ExceptionFunc = async exception =>
            //{
            //    if (exception is ProxyHttpException phex)
            //    {
            //        await WriteToConsole(exception.Message + ": " + phex.InnerException?.Message, true);
            //    }
            //    else
            //    {
            //        await WriteToConsole(exception.Message, true);
            //    }
            //};
            proxyServer.ForwardToUpstreamGateway = true;
            proxyServer.CertificateManager.SaveFakeCertificates = true;

            proxyServer.CertificateManager.PfxPassword = certPassword;
            proxyServer.CertificateManager.EnsureRootCertificate();
            proxyServer.CertificateManager.TrustRootCertificate(true);
            proxyServer.CertificateManager.TrustRootCertificateAsAdmin(true);

            if (!File.Exists(certName))
            {
                proxyServer.CertificateManager.CreateRootCertificate(true);
            }

            proxyServer.CertificateManager.RootCertificate = new X509Certificate2(certName, certPassword, X509KeyStorageFlags.Exportable);

            proxyServer.BeforeRequest += OnRequest;
            proxyServer.BeforeResponse += OnResponse;

            //proxyServer.ServerCertificateValidationCallback += OnCertificateValidation;
            //proxyServer.ClientCertificateSelectionCallback += OnCertificateSelection;

            var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Any, 8080);
            proxyServer.AddEndPoint(explicitEndPoint);


            //foreach (var endPoint in proxyServer.ProxyEndPoints)
            //{
            //    Console.WriteLine("Listening on '{0}' endpoint at Ip {1} and port: {2} ", endPoint.GetType().Name,
            //        endPoint.IpAddress, endPoint.Port);
            //}

            // Fired when a CONNECT request is received
            explicitEndPoint.BeforeTunnelConnectRequest += OnBeforeTunnelConnectRequest;
            explicitEndPoint.BeforeTunnelConnectResponse += OnBeforeTunnelConnectResponse;


            proxyServer.Start();

            //Only explicit proxies can be set as system proxy!
            proxyServer.SetAsSystemHttpProxy(explicitEndPoint);
            proxyServer.SetAsSystemHttpsProxy(explicitEndPoint);
            //if (RunTime.IsWindows)
            //{
            //    proxyServer.SetAsSystemProxy(explicitEndPoint, ProxyProtocolType.AllHttp);
            //}

            //Console.ReadLine();
        }

        public static void Stop()
        {
            if (proxyServer.ProxyRunning)
            {
                proxyServer.BeforeRequest -= OnRequest;
                proxyServer.BeforeResponse -= OnResponse;
                proxyServer.Stop();
            }
        }

        public static Task OnRequest(object sender, SessionEventArgs e)
        {
            _list.Add("Request : " + e.HttpClient.Request);
            //await WriteToConsole("Active Client Connections:" + ((ProxyServer)sender).ClientConnectionCount);
            //await WriteToConsole(e.HttpClient.Request.Url);
            return Task.FromResult(0);
        }

        public static Task OnResponse(object sender, SessionEventArgs e)
        {
            _list.Add("Responce : " + e.HttpClient.Response.StatusCode);
            //await WriteToConsole("Active Server Connections:" + ((ProxyServer)sender).ServerConnectionCount);
            return Task.FromResult(0);
        }

        //public static Task OnCertificateValidation(object sender, CertificateValidationEventArgs e)
        //{
        //    // set IsValid to true/false based on Certificate Errors
        //    if (e.SslPolicyErrors == SslPolicyErrors.None)
        //    {
        //        e.IsValid = true;
        //    }

        //    return Task.FromResult(0);
        //}

        //public static Task OnCertificateSelection(object sender, CertificateSelectionEventArgs e)
        //{
        //    // set e.clientCertificate to override

        //    return Task.FromResult(0);
        //}

        private static Task OnBeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
        {
            _list.Add("Tunnel to : " + e.HttpClient.Request.RequestUri.Host);

            return Task.FromResult(false);
        }

        private static Task OnBeforeTunnelConnectResponse(object sender, TunnelConnectSessionEventArgs e)
        {
            return Task.FromResult(false);
        }

        //private static async Task WriteToConsole(string message, bool useRedColor = false)
        //{
        //    await _lock.WaitAsync();

        //    if (useRedColor)
        //    {
        //        ConsoleColor existing = Console.ForegroundColor;
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine(message);
        //        Console.ForegroundColor = existing;
        //    }
        //    else
        //    {
        //        Console.WriteLine(message);
        //    }

        //    _lock.Release();

        //}
    }
}
