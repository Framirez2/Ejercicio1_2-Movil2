using Ejercicio1_2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1View());
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
