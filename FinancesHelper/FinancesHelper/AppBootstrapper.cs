using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Caliburn.Micro;
using System.Windows;
using Thud.Core.Shell.ViewModels;

namespace Thud
{
    public class AppBootstrapper : BootstrapperBase
    {
        private IKernel kernel;
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
            DisplayRootViewFor<ShellViewModel>();
        }
        protected override void Configure()
        {
            kernel = new StandardKernel();
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            kernel.Bind<AppServicesCollection>().To<AppServicesCollection>().InSingletonScope();

            kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            
        }
        protected override object GetInstance(Type service, string key)
        {
            return kernel.Get(service, key);//base.GetInstance(service, key);
        }



    }
}
