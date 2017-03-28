using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Crowe_HelloWorldService.Controllers
{
    public class HelloWorldController : ApiController
    {
        private IHelloWorldMessage helloWorldMsg;

        public HelloWorldController(IHelloWorldMessage helloWorldMsg)
        {
            this.helloWorldMsg = helloWorldMsg;
        }

        [ResponseType(typeof(HelloWorldMessage))]
        public IHttpActionResult GetHelloWorldMsg()
        {
            if (this.helloWorldMsg == null)
                return BadRequest();

            return Ok(this.helloWorldMsg.HelloWorldText);
       }
    }
}
