using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    public class SatelliteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}