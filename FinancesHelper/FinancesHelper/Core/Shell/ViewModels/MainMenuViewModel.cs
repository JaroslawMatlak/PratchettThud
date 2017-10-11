using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thud.Core.Shell.ViewModels
{
    public class MainMenuViewModel :Screen
    {
        private AppServicesCollection servicesCollection;
        public MainMenuViewModel(AppServicesCollection services)
        {
            servicesCollection = services;
            servicesCollection.EventAggregator.Subscribe(this);
        }
    }
}
