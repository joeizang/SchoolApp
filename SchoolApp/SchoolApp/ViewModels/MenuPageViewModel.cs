using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolApp.ViewModels
{
	public class MenuPageViewModel : BindableBase
	{
        private List<string> _menuItems = new List<string>
        {
            "Courses","Registration","Payments","Academics"
        };

        public List<string> MenuItems
        {
            get { return _menuItems; }
            set { SetProperty(ref _menuItems, value); }
        }

        public MenuPageViewModel()
        {

        }
	}
}
