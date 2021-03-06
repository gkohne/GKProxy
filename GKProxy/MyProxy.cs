﻿using System.IO;
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
        private static readonly ProxyServer proxyServer = new ProxyServer(true, true, true);

        public static void Start()
        {
            string certName = "rootCert.pfx";
            string certPassword = "Password";

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

            // Fired when a CONNECT request is received
            explicitEndPoint.BeforeTunnelConnectRequest += OnBeforeTunnelConnectRequest;
            explicitEndPoint.BeforeTunnelConnectResponse += OnBeforeTunnelConnectResponse;

            proxyServer.Start();

            //Only explicit proxies can be set as system proxy!
            proxyServer.SetAsSystemHttpProxy(explicitEndPoint);
            proxyServer.SetAsSystemHttpsProxy(explicitEndPoint);
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
            Sql.InsertData(e.HttpClient.Request.ToString());
            return Task.FromResult(0);
        }

        public static Task OnResponse(object sender, SessionEventArgs e)
        {
            Sql.InsertData(e.HttpClient.Response.ToString());
            return Task.FromResult(0);
        }

        private static Task OnBeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
        {
            Sql.InsertData("Tunnel to : " + e.HttpClient.Request.RequestUri);
            return Task.FromResult(false);
        }

        private static Task OnBeforeTunnelConnectResponse(object sender, TunnelConnectSessionEventArgs e)
        {
            return Task.FromResult(false);
        }

    }
}
