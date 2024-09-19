using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OpcionesController : Controller
    {
        public IActionResult Main()
        {
            var model = new OpcionModel();
            return View(model);
        }
    }
}
