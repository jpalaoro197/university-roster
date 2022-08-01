using Microsoft.AspNetCore.Mvc;

namespace UniversityRoster.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}