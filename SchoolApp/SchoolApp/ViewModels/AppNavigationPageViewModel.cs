using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolApp.ViewModels
{
    public class AppNavigationPageViewModel : BindableBase, INavigationPageOptions
    {
        private INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public AppNavigationPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "App Navigation";
        }

        public bool ClearNavigationStackOnNavigation => true;
    }
}
