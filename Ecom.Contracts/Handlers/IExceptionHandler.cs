using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Contracts.Handlers
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}
