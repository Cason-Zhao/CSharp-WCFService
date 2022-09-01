using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestByHeadCoded();
        }

        public static void TestByHeadCoded()
        {
            using (var serviceHost = new ServiceHost(typeof(HelloWorldService)))
            {
                #region 硬编码方式（若采用配置方式，则应移除当前代码）
                serviceHost.AddServiceEndpoint(typeof(IHelloWorld), new WSHttpBinding(), "http://127.0.0.1:8888/HelloWorldService");
                if(serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    var serviceBehavior = new ServiceMetadataBehavior();
                    serviceBehavior.HttpGetEnabled = true;
                    serviceBehavior.HttpsGetEnabled = true;
                    serviceBehavior.HttpGetUrl = new Uri("http://127.0.0.1:8888/HelloWorldService/metadata");
                    serviceBehavior.HttpsGetUrl = new Uri("https://127.0.0.1:8889/HelloWorldService/metadata");
                    serviceHost.Description.Behaviors.Add(serviceBehavior);
                }
                #endregion

                serviceHost.Opened += delegate
                {
                    Console.WriteLine("HelloService 启用成功，按任意键退出！");
                };

                serviceHost.Open();

                Console.ReadKey();
            }
        }
    }
}
