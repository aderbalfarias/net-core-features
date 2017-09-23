using Microsoft.AspNetCore.Mvc;

namespace AboutNetCore.Version1_0.DefaultTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Using ControllerContext
            var actionName = this.ControllerContext.ActionDescriptor.ActionName;
            var methodInfo = this.ControllerContext.ActionDescriptor.MethodInfo;

            //Example with httpContext, but there are other options to get info avoid HttpContext
            var headers = this.HttpContext.Response.Headers;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
