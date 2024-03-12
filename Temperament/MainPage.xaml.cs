using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
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
            Createpage("Koleeriline", "https://www.sellavio.ee/test/eysencki-temperamenditest/", "~/Temperament.Android/Resources/drawable/Koolerine.jpg", "Koleerik on subjekt, kellel on üks neljast põhilisest temperamenditüübist, mida iseloomustab kõrge vaimne aktiivsus, tegevuste jõulisus, teravus, hoogsus, liigutuste tugevus, nende kiire tempo, tormilisus.Koleerik on ärrituv, kannatamatu, kalduv emotsionaalsetele purunemistele, sageli agressiivne.");
            Createpage("Flegmaatiline", "https://www.sellavio.ee/test/eysencki-temperamenditest/", "~/Temperament.Android/Resources/drawable/Flegmatik.jpg", "Flegmaatilise temperamendiga inimest võib iseloomustada kui aeglast, rahulikku, stabiilsete püüdluste ja enam-vähem püsiva meeleoluga inimest, kelle vaimse seisundi väline väljendus on nõrk. Flegmaatikut iseloomustab tugev, tasakaalustatud, inertset tüüpi närvisüsteem. Sellistel inimestel on usaldusväärne mälu ja nad kipuvad tegema läbimõeldud, tasakaalustatud ja mitte riskantseid otsuseid.");
            Createpage("Melanhoolne", "https://www.sellavio.ee/test/eysencki-temperamenditest/", "~/Temperament.Android/Resources/drawable/Melonholik.jpg", "Melanhoolse temperamendiga inimest võib iseloomustada kui kergemeelset, kes kaldub sügavalt kogema isegi väiksemaid raskusi ja ebaõnnestumisi, kuid reageerib ümbritsevale väliselt lohakalt. Melanhoolikule on iseloomulik kõrge tundlikkus ja emotsionaalne tundlikkus, selle tagajärjel tekib kergus. Mõnes tegevusvaldkonnas on see soovitav isiksuseomadus, sest melanhoolse temperamendiga inimeste kõrge emotsionaalne tundlikkus võimaldab tabada teiste, eriti peente isiksuste peeneid emotsionaalseid väljundeid.");
            Createpage("Sanguline", "https://www.sellavio.ee/test/eysencki-temperamenditest/", "~/Temperament.Android/Resources/drawable/Sangiline.jpg", "Sangviinne on isiksus, keda iseloomustab suur vaimne aktiivsus, elujõud, tõhusus, liigutuste kiirus ja elavus, näoilmete mitmekesisus ja rikkalikkus, kiire kõnetempo. Sangviinidel on kalduvus sagedasele muljete muutumisele, nad reageerivad kergesti ja kiiresti ümbritsevatele sündmustele, on seltskondlikud. Sangviini emotsioonid on valdavalt positiivsed, need tekivad kiiresti ja muutuvad kiiresti. Ta kohaneb kiiresti uute tingimustega ja saab kiiresti inimestega läbi. Tema tunded tekivad kergesti ja asenduvad uutega, teda iseloomustab väljendusrikkus, kuid mõnikord ka tujukus.");

        }

        // ----------------------------------------------------------------------------------

        public void Createpage(string name, string url, string img, string text)
        {
            Button siteBtn = new Button
            {
                Text = "Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            siteBtn.Clicked += async (sender, e) =>
                await Browser.OpenAsync(url);

            Label Lbl = new Label
            {
                Text = name,
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton ImgBtn = new ImageButton
            {
                Source = img,
                HeightRequest = 400,
                WidthRequest = 200,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            ImgBtn.Clicked += async (sender, e) =>
                await DisplayAlert(name, text, "Sule");

            var Page = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        Lbl, ImgBtn, siteBtn
                    }
                }
            };
            Children.Add(Page);
        }
    }
}
