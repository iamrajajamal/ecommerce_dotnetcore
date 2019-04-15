using System;

namespace Ecom.Contracts.Handlers
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}
