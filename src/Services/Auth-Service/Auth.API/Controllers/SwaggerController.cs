
using Microsoft.AspNetCore.Mvc;
/**
    This controller should be only reachable on Develop
 */
namespace Auth.API.Controllers
{
    public class SwaggerController: Controller
    {
        
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
        
    }
}