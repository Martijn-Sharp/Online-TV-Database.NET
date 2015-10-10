using System.Net;

namespace OnlineTvDatabase.Core.Http
{
    public class HttpClientResponse
    {
        public HttpClientResponse(HttpStatusCode httpStatusCode, string responseBody)
        {
            ResponseBody = responseBody;
            HttpStatusCode = httpStatusCode;
        }

        public string ResponseBody { get; set; }

        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
