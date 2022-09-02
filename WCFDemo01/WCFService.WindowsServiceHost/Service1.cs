using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.WindowsServiceHost
{
    public partial class WindowsService : ServiceBase
    {
        public ServiceHost _ServiceHost;

        public WindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if(_ServiceHost != null)
            {
                _ServiceHost.Close();
            }

            _ServiceHost = new ServiceHost(typeof(WCFService.HelloWorldService));
            _ServiceHost.Open();
        }

        protected override void OnStop()
        {
            if(_ServiceHost != null)
            {
                _ServiceHost.Close();
                _ServiceHost = null;
            }
        }
    }
}
