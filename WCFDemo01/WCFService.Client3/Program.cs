using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.Client3.HelloWorldService;

namespace WCFService.Client3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var clientProxy = new HelloWorldServiceClient())
            {
                Console.Write($"Service visit success！Type any key to quit~{clientProxy.GetHelloWorld()}");
            }
            Console.ReadKey();
        }
    }
}
