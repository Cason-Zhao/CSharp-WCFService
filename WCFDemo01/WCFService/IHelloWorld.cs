using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WCFService
{
    /// <summary>
    /// IHelloWorld 的摘要说明
    /// </summary>
    [ServiceContract(Name = "HelloWorldService", Namespace = "http://www.LearnWCFService.com")]
    public interface IHelloWorld
    {
        [OperationContract]
        string GetHelloWorld();
    }
}

