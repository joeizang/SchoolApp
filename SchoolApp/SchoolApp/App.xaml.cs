﻿using Prism.Unity;
using SchoolApp.Views;
using Xamarin.Forms;

namespace SchoolApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService
            //    .NavigateAsync(new Uri("/SchoolAppMasterDetail/NavigationPage/MainPage",UriKind.Absolute));
            NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<SchoolAppMasterDetail>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Courses>();
            Container.RegisterTypeForNavigation<Registration>();
            Container.RegisterTypeForNavigation<MenuPage>();
        }
    }
}
