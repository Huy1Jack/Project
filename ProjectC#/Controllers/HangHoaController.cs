using Microsoft.AspNetCore.Mvc;

namespace ProjectC_.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai)
        {
            return View();
        }
    }
}
