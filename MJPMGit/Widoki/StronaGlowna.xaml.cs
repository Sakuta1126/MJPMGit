using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MJPMGit.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaGlowna : ContentPage
    {
        public StronaGlowna()
        {
            InitializeComponent();
        }

        private void gracz_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StonaGracz());
        }

        private void admin_Nnav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaAdmin());
        }

        private void wyniki_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaWynik());
        }

        private void zdrapka_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaZdrapka());
        }
    }
}