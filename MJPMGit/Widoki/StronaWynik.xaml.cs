using MJPMGit.Widoki.Klasy;
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
    public partial class StronaWynik : ContentPage
    {
        public StronaWynik()
        {
            InitializeComponent();
            listaWygranych.ItemsSource = App.Baza.Wypisz<Wynik>();
        }

        private void wyszukaj_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Wynik> listaWynikow = App.Baza.Wypisz<Wynik>();
            List<Wynik> nowaLista = listaWynikow.Where(wygrana => wygrana.Id.ToString().Contains(wyszukaj.Text)).ToList();
            listaWygranych.ItemsSource = nowaLista;
        }
    }
}