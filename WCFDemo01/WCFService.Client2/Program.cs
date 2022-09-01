using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Client2.HelloWorldService;

namespace WCFService.Client2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var proxyClient = new HelloWorldServiceClient())
            {
                Console.WriteLine($"服务访问成功：获取结果---》》》{proxyClient.GetHelloWorld()}");
            }

            Console.Read();
        }
    }
}
