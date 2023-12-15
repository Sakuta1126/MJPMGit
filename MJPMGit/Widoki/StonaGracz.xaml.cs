using MJPMGit.Widoki.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MJPMGit.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StonaGracz : ContentPage
    {
        public StonaGracz()
        {
            InitializeComponent();
        }

        private void aplikuj_Clicked(object sender, EventArgs e)
        {
            Gracz nowygracz = new Gracz(imie.Text,nazwisko.Text,email.Text,kod.Text);
            if(imie.Text!="" && nazwisko.Text!=""&&email.Text!=""&&kod.Text!="")
            {
                App.Baza.Zapisz(nowygracz);
                DisplayAlert("informacja", "zapisales sie do loterii", "OK");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("blad", "Pola uzupelnione nieprawidlowo", "OK");
            }
            imie.Text = "";
            nazwisko.Text = "";
            email.Text = "";
            kod.Text = "";
        }
    }
}