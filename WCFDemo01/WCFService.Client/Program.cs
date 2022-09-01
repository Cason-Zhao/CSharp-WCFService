using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Client.HelloWorldService;

namespace WCFService.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWCFService();
        }

        private static void TestWCFService()
        {
            using (var serviceClient = new HelloWorldServiceClient())
            {
                Console.WriteLine($"服务访问成功：获取结果---》》》{serviceClient.GetHelloWorld()}");
            }

            Console.Read();
        }
    }
}
