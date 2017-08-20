using Prism.Unity;
using SchoolApp.Views;
using System;
using Xamarin.Forms;

namespace SchoolApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService
                .NavigateAsync(new Uri("/SchoolAppMasterDetail/NavigationPage/MainPage",System.UriKind.Absolute));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SchoolAppMasterDetail>();
            Container.RegisterTypeForNavigation<Courses>();
            Container.RegisterTypeForNavigation<Registration>();
            Container.RegisterTypeForNavigation<MenuPage>();
        }
    }
}
