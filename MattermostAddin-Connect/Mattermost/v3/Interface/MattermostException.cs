﻿using System;

namespace MattermostAddinConnect.Mattermost.v3.Interface
{
    public class MattermostException : Exception
    {
        public string Details { get; private set; }

        public MattermostException(Error error) : base(error.Message)
        {
            Details = error.DetailedError;
        }
    }
}