namespace OnlineTvDatabase.Core.Http.Abstractions
{
    public interface IHttpClient
    {
        HttpClientResponse Get(string url);

	    string ContentType { get; set; }
    }
}
