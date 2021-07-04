using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
