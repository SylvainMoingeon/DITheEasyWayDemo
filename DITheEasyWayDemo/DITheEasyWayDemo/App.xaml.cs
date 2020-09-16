using DITheEasyWayDemo.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DITheEasyWayDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ICharacterService, MusketeerService>();

            MainPage = new MainPage();

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
