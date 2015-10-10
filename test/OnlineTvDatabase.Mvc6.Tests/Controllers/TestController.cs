using Microsoft.AspNet.Mvc;
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
    }
}
