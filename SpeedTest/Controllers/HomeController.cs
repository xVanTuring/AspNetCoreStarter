using System;
using Microsoft.AspNetCore.Mvc;

namespace SpeedTest.Controllers
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [Route("")]
        public ContentResult Index()
        {
            return Content("Hello World! From Home Controller! Updated!");
        }
        [Route("Number")]
        public string Number()
        {
            return "+10086";
        }
    }
}