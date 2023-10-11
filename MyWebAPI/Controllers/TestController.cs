using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController :ControllerBase
    {
        public string Get()
        {
            return "Hello from get";
        }

        public string Get1()
        {
            return "Hello from get1";
        }



    }
}
