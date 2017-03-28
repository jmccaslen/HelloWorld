using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowe_HelloWorldService
{
    public class HelloWorldMessage : IHelloWorldMessage
    {
        private string _text = "Hello World";
        public string HelloWorldText
        { 
            get { return _text; }
            set { _text = value; }
        }
    }
}