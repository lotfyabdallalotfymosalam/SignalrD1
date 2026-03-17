using Microsoft.AspNetCore.Mvc;

namespace SignalrD1.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
