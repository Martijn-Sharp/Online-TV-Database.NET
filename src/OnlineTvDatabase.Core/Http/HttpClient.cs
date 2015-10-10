using System.IO;
using System.Net;
using OnlineTvDatabase.Core.Http.Abstractions;

namespace OnlineTvDatabase.Core.Http
{
    public class HttpClient : IHttpClient
    {
        private HttpWebRequest _httpWebRequest;
        
        public HttpClient()
        {
            ContentType = "application/json";
        }
        
        public string ContentType { get; set; }
        
        public HttpClientResponse Get(string url)
        {
            _httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
            return MakeRequest("GET");
        }

        private HttpClientResponse MakeRequest(string method)
        {
            _httpWebRequest.Method = method;
            _httpWebRequest.ContentType = ContentType;
            _httpWebRequest.ContentLength = 0;

            using (var response = _httpWebRequest.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var responseStreamReader = new StreamReader(responseStream))
                        {
                            string responseFromServer = responseStreamReader.ReadToEnd();
                            return new HttpClientResponse(((HttpWebResponse) response).StatusCode, responseFromServer);
                        }
                    }
                }

                return new HttpClientResponse(((HttpWebResponse)response).StatusCode, null);
            }
        }
    }
}
