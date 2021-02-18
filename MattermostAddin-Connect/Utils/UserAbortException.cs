using System;

namespace MattermostAddinConnect.Utils
{
    public class UserAbortException : Exception
    {
        public UserAbortException()
        {
        }

        public UserAbortException(string message) : base(message)
        {
        }
    }
}