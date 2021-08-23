using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AjaxRestAPI.Controllers
{
    [Route("[controller]")]
    public class CallBackController : Controller
    {
        [Route("firstCall")]
        public string FirstCall()
        {
            Thread.Sleep(2000);
            return "First call";
        }

        [HttpGet]
        [Route("secondCall")]
        public string SecondCall()
        {
            Thread.Sleep(1000);
            return "Second call";
        }
    }
}
