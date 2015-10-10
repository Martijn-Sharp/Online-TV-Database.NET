namespace OnlineTvDatabase.Core.Models
{
    public class GetSeriesInput
    {
        public string SeriesName { get; set; }

        public Language Language { get; set; }

        public string AccountId { get; set; }
    }
}
