
using Microsoft.AspNetCore.Mvc;

namespace Newsboard.Services.AuthService.API.Controllers
{
    public class SwaggerController: Controller
    {
        public SwaggerController()
        {
           
        }
        
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
        
    }
}