using System;

namespace OnlineTvDatabase.Core.Models
{
    public class GetSeriesOutput
    {
        public int SeriesId { get; set; }

        public string Language { get; set; }

        public string SeriesName { get; set; }

        public string AliasNames { get; set; }

        public string Banner { get; set; }

        public string Overview { get; set; }

        public DateTime FirstAired { get; set; }

        public string ImdbId { get; set; }

        public string Zap2ItId { get; set; }

        public string Network { get; set; }
    }
}
