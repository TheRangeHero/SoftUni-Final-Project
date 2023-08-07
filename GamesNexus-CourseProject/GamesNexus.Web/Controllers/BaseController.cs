using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}
