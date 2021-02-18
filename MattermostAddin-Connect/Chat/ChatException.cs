using System;

namespace MattermostAddinConnect.Chat
{
    public class ChatException : Exception
    {
        public ChatException(string errorMessage, Exception innerException = null) : base(errorMessage, innerException)
        {
        }
    }
}