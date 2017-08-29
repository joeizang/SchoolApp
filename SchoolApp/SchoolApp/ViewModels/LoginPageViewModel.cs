using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;

namespace SchoolApp.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private IPageDialogService _dialogService;

        private INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public DelegateCommand LoginCommand { get; set; }

        public bool IsBusy { get; set; }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            LoginCommand = new DelegateCommand(OnLoginCommandExecute, CanExecuteLoginCommand)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => Password);
            _dialogService = dialogService;
            _navigationService = navigationService;
            Title = "School Login Page";
        }

        private async void OnLoginCommandExecute()
        {
            IsBusy = true;

            await _dialogService.DisplayAlertAsync("Success", "Your login was successful", "Ok","Back");

            //await Task.Delay(2000);

            await _navigationService.NavigateAsync(new Uri("/SchoolAppMasterDetail/NavigationPage/MainPage",UriKind.Absolute));


            IsBusy = false;
        }

        private bool CanExecuteLoginCommand() => !string.IsNullOrWhiteSpace(Username) 
                                    && !string.IsNullOrWhiteSpace(Password);

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
