using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Controllers
{
    public class PublisherController : BaseController
    {
        public async Task<IActionResult> Become()
        {
            return View();
        }
    }
}
