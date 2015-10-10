using System.Text;
using OnlineTvDatabase.Core.Factory;
using OnlineTvDatabase.Core.Models;

namespace OnlineTvDatabase.Core.Builders
{
    public class GetSeriesUrlBuilder : IObjectUrlBuilder<GetSeriesInput>
    {
        public string GetRelativeUrl()
        {
            return "GetSeries.php";
        }

        public string BuildQuery(GetSeriesInput input)
        {
            var queryBuilder = new StringBuilder();
            queryBuilder.Append($"seriesname={input.SeriesName}");
            if (input.Language != null)
            {
                queryBuilder.Append($"&language={input.Language.Abbreviation}");
            }

            if (!string.IsNullOrWhiteSpace(input.AccountId))
            {
                queryBuilder.Append($"&user={input.AccountId}");
            }

            return queryBuilder.ToString();
        }
    }
}
