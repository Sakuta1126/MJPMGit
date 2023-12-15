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
            Gracz nowygracz = new Gracz(imie.Text, nazwisko.Text, email.Text, kod.Text);
            if (imie.Text != "" && nazwisko.Text != "" && email.Text != "" && kod.Text != "" &&
                Regex.IsMatch(email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$") && Regex.IsMatch(kod.Text, @"^[0-9]{9}$"))
            {
                App.Baza.Zapisz(nowygracz);
                DisplayAlert("informacja", "Wziales udzial w loterii", "OK");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Blad", "Pola uzupelnione niepoprawnie", "OK");
            }

            imie.Text = "";
            nazwisko.Text = "";
            email.Text = "";
            kod.Text = "";
        }
    }
}