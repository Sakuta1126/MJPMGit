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
    public partial class StronaZdrapka : ContentPage
    {
        Random losowa = new Random();
        int a, b, c, d, x, f, g, h, i, j, k, l;
        bool odkrytoWygrywajacaLiczbe1 = false;
        bool odkrytoWygrywajacaLiczbe2 = false;
        bool odkrytoWygrywajacaLiczbe3 = false;
        public StronaZdrapka()
        {
            a = losowa.Next(51);
            b = losowa.Next(51);
            c = losowa.Next(51);
            d = losowa.Next(51);
            x = losowa.Next(51);
            f = losowa.Next(51);
            g = losowa.Next(51);
            h = losowa.Next(51);
            i = losowa.Next(51);
            j = losowa.Next(51);
            k = losowa.Next(51);
            l = losowa.Next(51);
            InitializeComponent();
            zdrapki.IsVisible = false;
        }
    
        private void SprawdzWidocznosc()
        {
            if (odkrytoWygrywajacaLiczbe1 && odkrytoWygrywajacaLiczbe2 && odkrytoWygrywajacaLiczbe3)
            {
                zdrapki.IsVisible = true;
            }
        }

        private async void OdkryjPole1(object sender, EventArgs e)
        {
            pole1.Text = d.ToString();
            pole1.ImageSource = "";
            if (a == d || b == d || c == d)
            { 
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _= Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole2(object sender, EventArgs e)
        {
            pole2.Text = x.ToString();
            pole2.ImageSource = "";
            if (a == x || b == x || c == x)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole3(object sender, EventArgs e)
        {
            pole3.Text = f.ToString();
            pole3.ImageSource = "";
            if (a == f || b == f || c == f)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole4(object sender, EventArgs e)
        {
            pole4.Text = g.ToString();
            pole4.ImageSource = "";
            if (a == g || b == g || c == g)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole5(object sender, EventArgs e)
        {
            pole5.Text = h.ToString();
            pole5.ImageSource = "";
            if (a == h || b == h || c == h)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole6(object sender, EventArgs e)
        {
            pole6.Text = i.ToString();
            pole6.ImageSource = "";
            if (a == i || b == i || c == i)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole7(object sender, EventArgs e)
        {
            pole7.Text=j.ToString();
            pole7.ImageSource = "";
            if (a == j || b == j || c == j)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole8(object sender, EventArgs e)
        {
            pole8.Text=k.ToString();
            pole8.ImageSource = "";
            if (a == k || b == k || c == k)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void OdkryjPole9(object sender, EventArgs e)
        {
            pole9.Text = l.ToString();
            pole9.ImageSource = "";
            if (a == l || b == l || c == l)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }
     
        private void OdkryjWygranaLiczbe1(object sender, EventArgs e)
        {
            odkrytoWygrywajacaLiczbe1 = true;
            SprawdzWidocznosc();
            wygranaLiczba1.Text = a.ToString();
            wygranaLiczba1.ImageSource = "";
        }

        private void OdkryjWygranaLiczbe2(object sender, EventArgs e)
        {
            odkrytoWygrywajacaLiczbe2 = true;
            SprawdzWidocznosc();
            wygranaLiczba2.Text = b.ToString();
            wygranaLiczba2.ImageSource = "";
        }

        private void OdkryjWygranaLiczbe3(object sender, EventArgs e)
        {
            odkrytoWygrywajacaLiczbe3 = true;
            SprawdzWidocznosc();
            wygranaLiczba3.Text = c.ToString();
            wygranaLiczba3.ImageSource = "";
        }
    }
}