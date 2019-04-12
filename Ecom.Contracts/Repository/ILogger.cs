using System;

namespace Ecom.Contracts.Repository
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}
