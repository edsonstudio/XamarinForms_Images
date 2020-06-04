using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.Forms;

namespace CA_Imagens
{
    public class DownloadImages : ContentPage
    {
        public DownloadImages()
        {
            var webImage = new Image { Aspect = Aspect.AspectFit };
            webImage.Source = ImageSource.FromUri(new Uri("https://aka.ms/campus.jpg"));

            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Imagem UriSource C#",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center
                    },

                    webImage,
                    new Label {Text = "Esta imagem foi baixada."},
                },

                Margin = new Thickness(20, 35, 20, 20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}
