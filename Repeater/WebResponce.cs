using System.IO;
using System.Net;
using System.Text;

namespace Repeater
{
    public static class WebResponce
    {
        public static string GetResponce(string uri, Method method)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = method.ToString();

            if (method == Method.POST)
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(request.ToString());
                request.ContentType = "application/json; charset=utf-8";
                request.ContentLength = byteArray.Length;
                var dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }
            string receiveContent = string.Empty;

            using (WebResponse response = request.GetResponse())
            {
                var responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    var reader = new StreamReader(responseStream);
                    receiveContent = reader.ReadToEnd();
                    reader.Close();
                }
            }
            return receiveContent;
        }

        public enum Method
        {
            // ReSharper disable once InconsistentNaming
            POST,
            // ReSharper disable once InconsistentNaming
            GET
        }
    }
}
