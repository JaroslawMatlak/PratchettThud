using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thud.Core.Shell.ViewModels
{
    public class ShellViewModel : Conductor<Screen>.Collection.AllActive
    {
        private AppServicesCollection servicesCollection;
        private MainMenuViewModel _menuControl;
        public MainMenuViewModel MenuControl
        {
            get => _menuControl;
            set 
            {
                _menuControl = value;
                NotifyOfPropertyChange(()=>MenuControl);
            }
        }



        public ShellViewModel(AppServicesCollection servicesCollection)
        {
            this.servicesCollection = servicesCollection;
            CreateComponents(servicesCollection);

        }

        private void CreateComponents(AppServicesCollection servicesCollection)
        {
            MenuControl = new MainMenuViewModel(servicesCollection);
            Items.Add(MenuControl);
        }

    }
}
