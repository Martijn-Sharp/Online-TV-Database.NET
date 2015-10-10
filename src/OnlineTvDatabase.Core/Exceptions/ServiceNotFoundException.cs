using System;

namespace OnlineTvDatabase.Core.Exceptions
{
    /// <summary>Exception that will be thrown when a service can't be found</summary>
    public class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException(Type type) : base($"Service {type.Name} could not be found")
        {
        }
    }
}
