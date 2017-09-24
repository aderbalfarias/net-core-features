using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces;
using AboutNetCore.Version1_0.DefaultTemplate.ViewModels.Test;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AboutNetCore.Version1_0.DefaultTemplate.Controllers
{
    public class TestController : Controller
    {
        private readonly ITesteService _testeService;

        public TestController(ITesteService testeService)
        {
            _testeService = testeService;
        }

        public IActionResult Index()
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

        public IActionResult Object()
        {
            var model = new TestViewModel
            {
                Id = 1,
                Name = "Hello World"
            };

            //return Json
            return new ObjectResult(model);
        }

        public IActionResult ViewDynamic()
        {

            var model = new Test
            {
                Id = 1,
                Name = "Hello World"
            };

            return View(model);
        }

        public IActionResult ViewDirective()
        {

            var model = new TestViewModel
            {
                Id = 1,
                Name = "Hello World"
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {

            var test = _testeService.Get(id);

            if (test == null)
                return RedirectToAction(nameof(Index));

            var model = new TestViewModel
            {
                Id = test.Id,
                Name = test.Name
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TestCreateViewModel model)
        {
            var entity = new Test
            {
                Name = model.Name
            };

            _testeService.Add(entity);

            //POST Redirect GET Patterns
            return RedirectToAction("Details", new { id = entity.Id });
        }
    }
}
