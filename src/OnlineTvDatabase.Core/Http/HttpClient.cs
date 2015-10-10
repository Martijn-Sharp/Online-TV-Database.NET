using System.IO;
using System.Net;
using OnlineTvDatabase.Core.Http.Abstractions;

namespace OnlineTvDatabase.Core.Http
{
    public class HttpClient : IHttpClient
    {
        public HttpClient()
        {
            ContentType = "application/json";
        }
        
        public string ContentType { get; set; }
        
        public HttpClientResponse Get(string url)
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(url);
            webRequest.Method = "GET";
            return MakeRequest(webRequest);
        }

        private HttpClientResponse MakeRequest(HttpWebRequest webRequest)
        {
            webRequest.ContentType = ContentType;
            webRequest.ContentLength = 0;

            using (var response = webRequest.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var responseStreamReader = new StreamReader(responseStream))
                        {
                            string responseFromServer = responseStreamReader.ReadToEnd();
                            return new HttpClientResponse(((HttpWebResponse)response).StatusCode, responseFromServer);
                        }
                    }
                }

                return new HttpClientResponse(((HttpWebResponse)response).StatusCode, null);
            }
        }
    }
}
