﻿using System;
using System.Threading.Tasks;


namespace R5T.D0006
{
    public interface IMessagesOutputFilePathProvider
    {
        Task<string> GetMessagesOutputFilePathAsync();
    }
}
