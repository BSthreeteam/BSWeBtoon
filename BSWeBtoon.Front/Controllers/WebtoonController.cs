using BSWeBtoon.Front.Services;
using Microsoft.AspNetCore.Mvc;

namespace BSWeBtoon.Front.Controllers
{
    public class WebtoonController : Controller
    {
        private readonly WebtoonService service;

        public WebtoonController(WebtoonService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
