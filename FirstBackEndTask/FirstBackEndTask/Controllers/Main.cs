using Microsoft.AspNetCore.Mvc;

namespace FirstBackEndTask.Controllers
{
    public class Main:Controller
    {
        public ViewResult detail() { return View(); }
        public ViewResult contact()
        {
            return View();
        }
        public ViewResult about()
        {
            return View();
        }
    }
}
