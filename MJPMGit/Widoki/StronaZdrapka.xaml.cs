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
        int licznik = 0;
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

        private void BrakWygranych()
        {
            licznik++;
            if(licznik == 9)
            {
                DisplayAlert("Przegrana", "Nie udało ci się wygrać.", "ok");
                _ = Navigation.PushAsync(new StronaGlowna());
            }
        }
        private async void OdkryjPole1(object sender, EventArgs e)
        {
            pole1.Text = d.ToString();
            if (pole1.ImageSource != null)
            {
                if (a == d || b == d || c == d)
                {
                    pole1.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole1.ImageSource = null;
        }

        private async void OdkryjPole2(object sender, EventArgs e)
        {
            pole2.Text = x.ToString();
            if (pole2.ImageSource != null)
            {
                if (a == x || b == x || c == x)
                {
                    pole2.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole2.ImageSource = null;
        }

        private async void OdkryjPole3(object sender, EventArgs e)
        {
            pole3.Text = f.ToString();
            if (pole3.ImageSource != null)
            {
                if (a == f || b == f || c == f)
                {
                    pole3.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole3.ImageSource = null;
        }

        private async void OdkryjPole4(object sender, EventArgs e)
        {
            pole4.Text = g.ToString();
            if (pole4.ImageSource != null)
            {
                if (a == g || b == g || c == g)
                {
                    pole4.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole4.ImageSource = null;
        }

        private async void OdkryjPole5(object sender, EventArgs e)
        {
            pole5.Text = h.ToString();
            if (pole5.ImageSource != null)
            {
                if (a == h || b == h || c == h)
                {
                    pole5.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole5.ImageSource = null;
        }

        private async void OdkryjPole6(object sender, EventArgs e)
        {
            pole6.Text = i.ToString();
            if (pole6.ImageSource != null)
            {
                if (a == i || b == i || c == i)
                {
                    pole6.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole6.ImageSource = null;
        }

        private async void OdkryjPole7(object sender, EventArgs e)
        {
            pole7.Text=j.ToString();
            if (pole7.ImageSource != null)
            {
                if (a == j || b == j || c == j)
                {
                    pole7.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole7.ImageSource = null;
        }

        private async void OdkryjPole8(object sender, EventArgs e)
        {
            pole8.Text=k.ToString();
            if (pole8.ImageSource != null)
            {
                if (a == k || b == k || c == k)
                {
                    pole8.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole8.ImageSource = null;
        }

        private async void OdkryjPole9(object sender, EventArgs e)
        {
            pole9.Text = l.ToString();
            if (pole9.ImageSource != null)
            {
                if (a == l || b == l || c == l)
                {
                    pole9.ImageSource = null;
                    await DisplayAlert("Wygrana", "Gratulację, wygrałeś główną nagrodę.", "ok");
                    _ = Navigation.PushAsync(new StronaGlowna());
                }
                else
                {
                    BrakWygranych();
                }
            }
            pole9.ImageSource = null;
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