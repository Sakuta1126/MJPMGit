using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MJPMGit.Widoki;
using MJPMGit.Widoki.Klasy;
using System.IO;

namespace MJPMGit
{
    public partial class App : Application
    {
        private static BazaDanych baza;

        public static BazaDanych Baza
        {
            get
            {
                if (baza == null)
                {
                    baza = new BazaDanych(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bazaSprawdziannn.db3"));
                }
                return baza;
            }
        }
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
