using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OnlineTvDatabase.Core.Models
{
    /// <summary>
    /// Output object that resembles the response body of the GetSeries API method
    /// </summary>
    [XmlRoot("Data")]
    public class GetSeriesOutput
    {
        [XmlElement("Series")]
        public List<Series> Series { get; set; }
    }

    public class Series
    {
        /// <summary>Series identifier</summary>
        [XmlElement("seriesid")]
        public int SeriesId { get; set; }

        /// <summary>Two digit string indicating the language</summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>Series name for the language indicated</summary>
        public string SeriesName { get; set; }

        /// <summary>
        /// List of alias names if the series has any other names in the language indicated.
        /// Delimited by the pipe ('|') character.
        /// </summary>
        public string AliasNames { get; set; }

        /// <summary>
        /// Relative path to the highest rated banner for this series.
        /// Append "http://thetvdb.com" to the start of it to get the absolute path.
        /// </summary>
        [XmlElement("banner")]
        public string Banner { get; set; }

        /// <summary>Overview of the series in the language indicated</summary>
        public string Overview { get; set; }

        /// <summary>The first aired date for the series</summary>
        public DateTime FirstAired { get; set; }

        /// <summary>The IMDB ID for the series, if known</summary>
        [XmlElement("IMDB_ID")]
        public string ImdbId { get; set; }

        /// <summary>The Zap2It ID for the series, if known</summary>
        [XmlElement("zap2it_id")]
        public string Zap2ItId { get; set; }

        /// <summary>Network name, if known</summary>
        public string Network { get; set; }
    }
}
