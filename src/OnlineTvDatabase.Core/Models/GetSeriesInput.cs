namespace OnlineTvDatabase.Core.Models
{
    /// <summary>Input object that resembles the input parameters for the GetSeries API method</summary>
    public class GetSeriesInput
    {
        /// <summary>
        /// This is the string you want to search for. 
        /// If there is an exact match for the parameter, it will be the first result returned.
        /// </summary>
        public string SeriesName { get; set; }

        /// <summary>
        /// This is for the language you want to search in. 
        /// If omitted, it will default to en (English). 
        /// This may also be set to all by initializing a new Language object
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// This is a users account Identifier. 
        /// If given it will use the language their account is set to. 
        /// The account ID can be found by going to http://thetvdb.com/?tab=userinfo
        /// </summary>
        public string AccountId { get; set; }
    }
}
