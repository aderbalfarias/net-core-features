using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces;
using AboutNetCore.Version1_0.DefaultTemplate.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AboutNetCore.Version1_0.DefaultTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITesteService _testeService;

        public HomeController(ITesteService testeService)
        {
            _testeService = testeService;
        }

        public IActionResult Index()
        {
            //Using ControllerContext
            var actionName = this.ControllerContext.ActionDescriptor.ActionName;
            var methodInfo = this.ControllerContext.ActionDescriptor.MethodInfo;

            //Example with httpContext, but there are other options to get info avoid HttpContext
            var headers = this.HttpContext.Response.Headers;

            return View();
        }

        public IActionResult TestObject()
        {
            var model = new TestViewModel
            {
                Id = 1,
                Name = "Hello World"
            };

            //return Json
            return new ObjectResult(model);
        }

        public IActionResult TestViewList()
        {
            var model = _testeService
                .GetAll()
                .Select(s => new TestViewModel
                {
                    Id = s.Id,
                    Name = s.Name
                });

            return View(model);
        }

        public IActionResult TestViewDynamic()
        {

            var model = new Test
            {
                Id = 1,
                Name = "Hello World"
            };

            return View(model);
        }

        public IActionResult TestViewDirective()
        {

            var model = new TestViewModel
            {
                Id = 1,
                Name = "Hello World"
            };

            return View(model);
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
