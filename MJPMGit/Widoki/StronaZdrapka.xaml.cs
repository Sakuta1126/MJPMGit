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
        Random random = new Random();
        int a, b, c, d, x, f, g, h, i, j, k, l;
            bool btn4Clicked = false;
            bool btn8Clicked = false;
            bool btn12Clicked = false;
        public StronaZdrapka()
        {
            a = random.Next(51);
            b = random.Next(51);
            c = random.Next(51);
            d = random.Next(51);
            x = random.Next(51);
            f = random.Next(51);
            g = random.Next(51);
            h = random.Next(51);
            i = random.Next(51);
            j = random.Next(51);
            k = random.Next(51);
            l = random.Next(51);
            InitializeComponent();
            zdrapki.IsVisible = false;
        }
    
        private void CheckVisibility()
        {
            if (btn4Clicked && btn8Clicked && btn12Clicked)
            {
                zdrapki.IsVisible = true;
            }
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            btn1.Text = d.ToString();
            btn1.ImageSource = "";
            if (a == d || b == d || c == d)
            { 
            await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
           Navigation.PushAsync(new StronaGlowna());
            
            }

        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            btn2.Text = x.ToString();
            btn2.ImageSource = "";
            if (a == x || b == x || c == x)
            {
            await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
          Navigation.PushAsync(new StronaGlowna());

            }
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            btn3.Text = f.ToString();
            btn3.ImageSource = "";
            if (a == f || b == f || c == f)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
          Navigation.PushAsync(new StronaGlowna());

            }
        }

        private async void btn5_Clicked(object sender, EventArgs e)
        {
            btn5.Text = g.ToString();
            btn5.ImageSource = "";
            if (a == g || b == g || c == g)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
           Navigation.PushAsync(new StronaGlowna());

            }
        }

        private async void btn6_Clicked(object sender, EventArgs e)
        {
            btn6.Text = h.ToString();
            btn6.ImageSource = "";
            if (a == h || b == h || c == h)
            {

                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
             Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void btn7_Clicked(object sender, EventArgs e)
        {
            btn7.Text = i.ToString();
            btn7.ImageSource = "";
            if (a == i || b == i || c == i)
            {

                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
          Navigation.PushAsync(new StronaGlowna());
            }
        }

        private async void btn9_Clicked(object sender, EventArgs e)
        {
            btn9.Text=j.ToString();
            btn9.ImageSource = "";
            if (a == j || b == j || c == j)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
           Navigation.PushAsync(new StronaGlowna());

            }
        }

        private async void btn10_Clicked(object sender, EventArgs e)
        {
            btn10.Text=k.ToString();
            btn10.ImageSource = "";
            if (a == k || b == k || c == k)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
            Navigation.PushAsync(new StronaGlowna());

            }
        }

        private async void btn11_Clicked(object sender, EventArgs e)
        {
            btn11.Text = l.ToString();
            btn11.ImageSource = "";
            if (a == l || b == l || c == l)
            {
                await DisplayAlert("Wygrales", "udalo ci sie wygrac glowna nagrode zdrapkowa", "ok");
            Navigation.PushAsync(new StronaGlowna());

            }
        }
     
        private void btn4_Clicked_1(object sender, EventArgs e)
        {
            btn4Clicked = true;
            CheckVisibility();
            btn4.Text = a.ToString();
            btn4.ImageSource = "";
        }

        private void btn8_Clicked_1(object sender, EventArgs e)
        {
            btn8Clicked = true;
            CheckVisibility();
            btn8.Text = b.ToString();
            btn8.ImageSource = "";
        }

        private void btn12_Clicked_1(object sender, EventArgs e)
        {
            btn12Clicked = true;
            CheckVisibility();
            btn12.Text = c.ToString();
            btn12.ImageSource = "";
        }
    }
}