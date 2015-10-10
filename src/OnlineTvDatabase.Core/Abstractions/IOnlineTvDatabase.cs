using OnlineTvDatabase.Core.Models;

namespace OnlineTvDatabase.Core.Abstractions
{
    public interface IOnlineTvDatabase
    {
        GetSeriesOutput GetSeries(GetSeriesInput requestData);

        void GetSeriesByRemoteId();

        void GetEpisodeByAirDate();

        void GetRatingsForUser();

        void UserPreferredLanguage();

        void UserFavorites();

        void UserRating();
    }
}
