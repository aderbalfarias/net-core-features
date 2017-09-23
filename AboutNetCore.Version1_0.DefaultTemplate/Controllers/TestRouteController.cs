using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AboutNetCore.Version1_0.DefaultTemplate.Controllers
{
    //[Route("[controller]")]
    //[Route("[controller]/[action]")]
    [Route("test")]

    public class TestRouteController : Controller
    {
        [Route("")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            ViewBag.Route = "Get Index";

            return View();
        }

        [Route("xy")]
        //[Route("[action]")]
        public IActionResult GetXpto()
        {
            ViewBag.Route = "Get Index";

            return View();
        }
    }
}
