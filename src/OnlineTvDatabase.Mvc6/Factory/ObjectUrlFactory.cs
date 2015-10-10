using System;
using OnlineTvDatabase.Core.Exceptions;
using OnlineTvDatabase.Core.Factory;

namespace OnlineTvDatabase.Mvc6.Factory
{
    public class ObjectUrlFactory : IObjectUrlFactory
    {
        public ObjectUrlFactory(IServiceProvider provider)
        {
            Provider = provider;
        }

        public IServiceProvider Provider { get; set; }

        public Uri Create<T>(T input)
        {
            var builder = GetService<IObjectUrlBuilder<T>>();
            var uriBuilder = new UriBuilder(@"http://thetvdb.com/api/" + builder.GetRelativeUrl()) {Query = builder.BuildQuery(input)};
            return uriBuilder.Uri;
        }

        /// <summary>Get the service</summary>
        /// <exception cref="ServiceNotFoundException">Throws if the service can't be found</exception>
        /// <returns>An instance of the service implementation</returns>
        protected virtual TService GetService<TService>()
        {
            // Get the service from the provider
            var service = (TService)Provider.GetService(typeof(TService));
            if (service != null)
            {
                return service;
            }

            throw new ServiceNotFoundException(typeof(TService));
        }
    }
}
