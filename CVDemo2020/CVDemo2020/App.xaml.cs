using CVDemo2020.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CVDemo2020
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new ProductView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
