using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService
{
    /// <summary>
    /// HelloWorld 的摘要说明
    /// </summary>
    public class HelloWorldService : IHelloWorld
    {
        public string GetHelloWorld()
        {
            return "HelloWorld!";
        }
    }
}