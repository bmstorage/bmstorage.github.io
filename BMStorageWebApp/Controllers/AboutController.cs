using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BMStorage.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}