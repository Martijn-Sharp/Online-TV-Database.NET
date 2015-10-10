using System;
using OnlineTvDatabase.Core.Abstractions;
using OnlineTvDatabase.Core.Factory;
using OnlineTvDatabase.Core.Http.Abstractions;
using OnlineTvDatabase.Core.Models;

namespace OnlineTvDatabase.Mvc6
{
    public class OnlineTvDatabaseClient : IOnlineTvDatabase
    {
        public OnlineTvDatabaseClient(IHttpClient httpClient, IObjectUrlFactory urlFactory)
        {
            HttpClient = httpClient;
            UrlFactory = urlFactory;
        }

        public IHttpClient HttpClient { get; set; }

        public IObjectUrlFactory UrlFactory { get; set; }

        public GetSeriesOutput GetSeries(GetSeriesInput requestData)
        {
            var response = HttpClient.Get(UrlFactory.Create(requestData).ToString());
            return new GetSeriesOutput();
        }

        public void GetSeriesByRemoteId()
        {
            throw new NotImplementedException();
        }

        public void GetEpisodeByAirDate()
        {
            throw new NotImplementedException();
        }

        public void GetRatingsForUser()
        {
            throw new NotImplementedException();
        }

        public void UserPreferredLanguage()
        {
            throw new NotImplementedException();
        }

        public void UserFavorites()
        {
            throw new NotImplementedException();
        }

        public void UserRating()
        {
            throw new NotImplementedException();
        }
    }
}
