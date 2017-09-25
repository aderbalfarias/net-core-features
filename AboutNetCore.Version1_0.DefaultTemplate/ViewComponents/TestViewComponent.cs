using AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AboutNetCore.Version1_0.DefaultTemplate.ViewComponents
{
    public class TestViewComponent : ViewComponent
    {
        private readonly ITesteService _testeService;

        public TestViewComponent(ITesteService testeService)
        {
            _testeService = testeService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var model = _testeService.TestViewComponent();
            return Task.FromResult<IViewComponentResult>(View("Default", model));
        }
    }
}
