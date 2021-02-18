using System;

namespace MattermostAddinConnect.Http
{
    public interface IHttpResponse : IDisposable
    {
        string GetHeaderValue(string key);
        string GetPayload();
    }
}