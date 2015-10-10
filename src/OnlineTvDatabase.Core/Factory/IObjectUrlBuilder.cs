namespace OnlineTvDatabase.Core.Factory
{
    public interface IObjectUrlBuilder<in T>
    {
        string GetRelativeUrl();

        string BuildQuery(T input);
    }
}
