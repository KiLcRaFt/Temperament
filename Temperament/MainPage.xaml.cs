using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button siteBtn1 = new Button
            {
                Text = "Test",
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions= LayoutOptions.End
            };
            siteBtn1.Clicked += SiteBtn_Clicked;

            Label holerikLbl = new Label
            {
                Text = "Koleeriline",
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton HolerikImgBtn = new ImageButton
            {
                Source = "~/Temperament.Android/Resources/drawable/Koolerine.jpg",
                HeightRequest = 400,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            HolerikImgBtn.Clicked += HolerikImgBtn_Clicked;

            var KoleerilinePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        holerikLbl, HolerikImgBtn, siteBtn1
                    }
                }
            };

            //----------------------------------------------------------------------

            Button siteBtn2 = new Button
            {
                Text = "Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            siteBtn2.Clicked += SiteBtn2_Clicked;

            Label FlegmaatilineLbl = new Label
            {
                Text = "Flegmaatiline",
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton FlegmaatilineImgBtn = new ImageButton
            {
                Source = "~/Temperament.Android/Resources/drawable/Flegmatik.jpg",
                HeightRequest = 400,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            FlegmaatilineImgBtn.Clicked += FlegmaatilineImgBtn_Clicked;

            var FlegmaatilinePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        FlegmaatilineLbl, FlegmaatilineImgBtn, siteBtn2
                    }
                }
            };

            //----------------------------------------------------------------------

            Button siteBtn3 = new Button
            {
                Text = "Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            siteBtn3.Clicked += SiteBtn3_Clicked;

            Label MelanhoolneLbl = new Label
            {
                Text = "Melanhoolne",
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton MelanhoolneImgBtn = new ImageButton
            {
                Source = "~/Temperament.Android/Resources/drawable/Melonholik.jpg",
                HeightRequest = 400,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            MelanhoolneImgBtn.Clicked += MelanhoolneImgBtn_Clicked;

            var MelanhoolnePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        MelanhoolneLbl, MelanhoolneImgBtn, siteBtn3
                    }
                }
            };

            //---------------------------------------------------------------------

            Button siteBtn4 = new Button
            {
                Text = "Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            siteBtn4.Clicked += SiteBtn4_Clicked;

            Label SangulineLbl = new Label
            {
                Text = "Sanguline",
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton SangulineImgBtn = new ImageButton
            {
                Source = "~/Temperament.Android/Resources/drawable/Sangiline.jpg",
                HeightRequest = 400,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            SangulineImgBtn.Clicked += SangulineImgBtn_Clicked;

            var SangulinePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        SangulineLbl, SangulineImgBtn, siteBtn4
                    }
                }
            };

            //---------------------------------------------------------------------
            Children.Add(KoleerilinePage);
            Children.Add(FlegmaatilinePage);
            Children.Add(MelanhoolnePage);
            Children.Add(SangulinePage);
        }

        private async void SiteBtn4_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.sellavio.ee/test/eysencki-temperamenditest/");
        }

        private async void SiteBtn3_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.sellavio.ee/test/eysencki-temperamenditest/");
        }

        private async void SiteBtn2_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.sellavio.ee/test/eysencki-temperamenditest/");
        }

        private async void SiteBtn_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.sellavio.ee/test/eysencki-temperamenditest/");
        }

        private async void SangulineImgBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sanguline", "Sangviinne on isiksus, keda iseloomustab suur vaimne aktiivsus, elujõud, tõhusus, liigutuste kiirus ja elavus, näoilmete mitmekesisus ja rikkalikkus, kiire kõnetempo. Sangviinidel on kalduvus sagedasele muljete muutumisele, nad reageerivad kergesti ja kiiresti ümbritsevatele sündmustele, on seltskondlikud. Sangviini emotsioonid on valdavalt positiivsed, need tekivad kiiresti ja muutuvad kiiresti. Ta kohaneb kiiresti uute tingimustega ja saab kiiresti inimestega läbi. Tema tunded tekivad kergesti ja asenduvad uutega, teda iseloomustab väljendusrikkus, kuid mõnikord ka tujukus.", "Sule");
        }

        private async void MelanhoolneImgBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Melanhoolne", "Melanhoolse temperamendiga inimest võib iseloomustada kui kergemeelset, kes kaldub sügavalt kogema isegi väiksemaid raskusi ja ebaõnnestumisi, kuid reageerib ümbritsevale väliselt lohakalt. Melanhoolikule on iseloomulik kõrge tundlikkus ja emotsionaalne tundlikkus, selle tagajärjel tekib kergus. Mõnes tegevusvaldkonnas on see soovitav isiksuseomadus, sest melanhoolse temperamendiga inimeste kõrge emotsionaalne tundlikkus võimaldab tabada teiste, eriti peente isiksuste peeneid emotsionaalseid väljundeid.", "Sule");
        }

        private async void FlegmaatilineImgBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Flegmaatiline", "Koleerik on subjekt, kellel on üks neljast põhilisest temperamenditüübist, mida iseloomustab kõrge vaimne aktiivsus, tegevuste jõulisus, teravus, hoogsus, liigutuste tugevus, nende kiire tempo, tormilisus. Koleerik on ärrituv, kannatamatu, kalduv emotsionaalsetele purunemistele, sageli agressiivne.", "Sule");
        }

        private async void HolerikImgBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Koleeriline", "Flegmaatilise temperamendiga inimest võib iseloomustada kui aeglast, rahulikku, stabiilsete püüdluste ja enam-vähem püsiva meeleoluga inimest, kelle vaimse seisundi väline väljendus on nõrk. Flegmaatikut iseloomustab tugev, tasakaalustatud, inertset tüüpi närvisüsteem. Sellistel inimestel on usaldusväärne mälu ja nad kipuvad tegema läbimõeldud, tasakaalustatud ja mitte riskantseid otsuseid.", "Sule");
        }
    }
}
