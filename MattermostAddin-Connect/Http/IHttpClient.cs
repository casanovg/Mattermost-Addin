using System;

namespace MattermostAddinConnect.Http
{
    public interface IHttpClient
    {
        IHttpRequest Request(Uri url);
    }
}