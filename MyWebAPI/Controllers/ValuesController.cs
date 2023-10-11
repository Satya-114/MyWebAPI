using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MyWebAPI.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/Get-All")]
        public string GetAll()
        {
            return "Hi from GetAllbooks";
        }

        [Route("api/Get-AllAuthors")]
        public string GetAllAuthors()
        {
            return "Hi from GetAllAuthors";
        }

        [Route("book/id")]
        public string GetById(int id)
        {
            return "Hello" + id;
        }

        [Route("search")]
        public string SearchBooks(int id, int authorid, string name, int price, int rating)
        {
            return "hello from search";
        }
    }
   
}
