using graph_sample.Helper;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace graph_sample.Controllers
{
    public class CalendarController : BaseController
    {
        // GET: Calendar
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var events = await GraphHelper.GetEventsAsync();
            return View(events);
        }
    }
}