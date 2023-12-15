using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using MJPMGit.Widoki.Klasy;

namespace MJPMGit.Widoki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaAdmin : ContentPage
    {
        public StronaAdmin()
        {
            InitializeComponent();
        }

        void WyslijMail(string doKogo, string tytul, string opis)
        {
            MailMessage wiadomosc = new MailMessage("sprawdziangit@outlook.com",doKogo,tytul,opis); 
            SmtpClient klient = new SmtpClient("smtp-mail.outlook.com",587);
            klient.EnableSsl = true;
            klient.Credentials = new NetworkCredential("sprawdziangit@outlook.com", "Haslo123");
            klient.UseDefaultCredentials = false;
            klient.Send(wiadomosc);
        }

        private void losowanie_Clicked(object sender, EventArgs e)
        {
            int licznikWygranych = 0;
            Random losowa = new Random();
            string wynik = "";
            for(int i = 0; i<9;i++)
            {
                wynik += losowa.Next(0, 10);
            }
            List<Gracz> listaGraczy = App.Baza.Wypisz<Gracz>();
            foreach(Gracz gracz in listaGraczy)
            {
                if(gracz.Kod == wynik)
                {
                    WyslijMail(gracz.Email, "Gratuluje wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                    licznikWygranych++;
                }
            }
            DateTime data =  DateTime.Now;
            Wynik dodawanyWynik = new Wynik(data,wynik, licznikWygranych);
            App.Baza.Zapisz(dodawanyWynik);
            dataLosowania.Text = "Data losowania: "+ dodawanyWynik.DataLosowania.ToString();
            iloscWygranych.Text = "Ilosc wygranych: "+licznikWygranych.ToString();
            wygranyKod.Text = "Wygrany kod: " + wynik;
        }

        private void kazdyWygrywa_Clicked(object sender, EventArgs e)
        {
            int licznikWygranych = 0;
            string wynik = "kazdy wygrywa";
            
            List<Gracz> listaGraczy = App.Baza.Wypisz<Gracz>();
            foreach (Gracz gracz in listaGraczy)
            {
                WyslijMail(gracz.Email, "Gratuluje wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                licznikWygranych++;
            }
            DateTime data = DateTime.Now;
            Wynik dodawanyWynik = new Wynik(data, wynik, licznikWygranych);
            App.Baza.Zapisz(dodawanyWynik);
            dataLosowania.Text = "Data losowania: " + dodawanyWynik.DataLosowania.ToString();
            iloscWygranych.Text = "Ilosc wygranych: " + licznikWygranych.ToString();
            wygranyKod.Text = "Wygrany kod: " + wynik;
        }
    }
}