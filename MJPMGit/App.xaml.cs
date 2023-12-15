using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MJPMGit.Widoki;
namespace MJPMGit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StronaGlowna());
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
