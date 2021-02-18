using System;
using System.Net;

namespace MattermostAddinConnect.Http
{
    public class DotNetHttpClient : IHttpClient
    {
        public IHttpRequest Request(Uri url)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
            return new HttpWebRequestAdaptor(httpWebRequest);
        }
    }
}