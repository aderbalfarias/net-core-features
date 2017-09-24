using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AboutNetCore.Version1_0.DefaultTemplate.Controllers
{
    //[Route("[controller]")]
    //[Route("[controller]/[action]")]
    [Route("Xpto")]

    public class TestRouteController : Controller
    {
        [Route("")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            //return Content("Index");
            return View();
        }

        [Route("Test")]
        //[Route("[action]")]
        public IActionResult GetXpto()
        {
            //return Content("GetXpto");
            return View();
        }
    }
}
