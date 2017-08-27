using Prism.Mvvm;
using Prism.Navigation;

namespace SchoolApp.ViewModels
{
    public class CoursesViewModel : BindableBase, INavigationAware
    {

        private INavigationService _navigationService;

        public CoursesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
