using Microsoft.AspNet.Mvc;
using OnlineTvDatabase.Core;
using OnlineTvDatabase.Core.Abstractions;
using OnlineTvDatabase.Core.Models;

namespace OnlineTvDatabase.Mvc6.Tests.Controllers
{
    public class TestController : Controller
    {
        public TestController(IOnlineTvDatabase onlineTvDatabase)
        {
            OnlineTvDatabase = onlineTvDatabase;
        }

        public IOnlineTvDatabase OnlineTvDatabase { get; set; }

        public IActionResult Index()
        {
            OnlineTvDatabase.GetSeries(new GetSeriesInput {SeriesName = "Firefly"});
            return HttpNotFound();
        }

        public IActionResult SeriesNameOnly()
        {
            return Json(OnlineTvDatabase.GetSeries(new GetSeriesInput {SeriesName = "Firefly"}));
        }

        public IActionResult SeriesNameInDutch()
        {
            return Json(OnlineTvDatabase.GetSeries(new GetSeriesInput { SeriesName = "Firefly", Language = Language.Dutch}));
        }

        public IActionResult SeriesNameInUserLanguage()
        {
            return Json(OnlineTvDatabase.GetSeries(new GetSeriesInput { SeriesName = "Firefly", AccountId = "502641CEB39C24DF" }));
        }

        public IActionResult MultipleSeries()
        {
            return Json(OnlineTvDatabase.GetSeries(new GetSeriesInput {SeriesName = "Supernatural"}));
        }

        public IActionResult SpecialCharacter()
        {
            return Json(OnlineTvDatabase.GetSeries(new GetSeriesInput {SeriesName = "Mike & Molly"}));
        }
    }
}
