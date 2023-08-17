using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesNexus.Web.Areas.Admin.Controllers
{
    using static GamesNexus.Common.GeneralApplicationConstants;


    [Area(AdminAreaName)]
    [Authorize(Roles =AdminRoleName)]
    public class BaseAdminController : Controller
    {
       
    }
}
