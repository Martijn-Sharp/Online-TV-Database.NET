using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
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
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            var output = DeserializeAs<GetSeriesOutput>(response.ResponseBody);
            return output;
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

        protected T DeserializeAs<T>(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            TextReader reader = new StringReader(xml);
            return (T) xmlSerializer.Deserialize(reader);
        }
    }
}
