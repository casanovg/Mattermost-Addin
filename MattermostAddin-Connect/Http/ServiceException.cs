using System;

namespace MattermostAddinConnect.Http
{
    public class ServiceException : Exception
    {
        public IHttpResponse Response { get; private set; }

        public ServiceException(IHttpResponse response)
        {
            Response = response;
        }
    }
}