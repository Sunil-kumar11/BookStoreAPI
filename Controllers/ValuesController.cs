using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> get()
        {
            return new string[] { "values 1", "values 2" ,"values 3","values 4" };
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "the string is " + id;
        }

    }
}
