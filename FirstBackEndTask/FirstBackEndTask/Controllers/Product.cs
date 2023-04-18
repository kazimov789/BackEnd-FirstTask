using Microsoft.AspNetCore.Mvc;

namespace FirstBackEndTask.Controllers
{
    public class Product:Controller
    {
        public ContentResult detail(int id)
        {
            return Content(id.ToString()) ;
        }
    }
}
