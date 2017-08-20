using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolApp.ViewModels
{
    public class SchoolAppMasterDetailViewModel : BindableBase
    {

        private INavigationService _navigationService;

        public DelegateCommand<string> OnNavigateCommand { get; set; }

        public SchoolAppMasterDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnNavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(string obj)
        {
            await _navigationService.NavigateAsync(new Uri(obj, UriKind.Relative));
        }
    }
}
