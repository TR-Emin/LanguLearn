using LanguLearn.Infrastructure.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguLearn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        [HttpGet]
        [Route("TestFunc")]
        public Test TestFunc()
        {
            Test test = new Test
            {
                Id = 1,
                Name = "TestData",
            };

            return test;
        }
    }
}
