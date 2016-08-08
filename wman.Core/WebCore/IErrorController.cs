using System;

namespace wman.Core.WebCore
{
    public interface IErrorController
    {
        string OnError(Exception e);
    }
}