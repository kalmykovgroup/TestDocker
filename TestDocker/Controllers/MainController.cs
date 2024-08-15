using Microsoft.AspNetCore.Mvc;

namespace TestDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        
       
 

        [HttpGet(Name = "test")]
        public string Get()
        {
            return "Hello world!1";
        }
    }
}
