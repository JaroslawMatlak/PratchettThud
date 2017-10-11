using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thud
{
    public class AppServicesCollection
    {
        public IEventAggregator EventAggregator { get; private set; }
        public IWindowManager WindowManager { get; private set; }
        public AppServicesCollection(
            IEventAggregator eventAggregator,
            IWindowManager windowManager
            )
        {
            EventAggregator = eventAggregator;
            WindowManager = windowManager;
        }
    }
}
