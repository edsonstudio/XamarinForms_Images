using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CA_Imagens
{
    public class EmbeddedImages : ContentPage
    {
        public EmbeddedImages()
        {
            var embeddedImage = new Image { Aspect = Aspect.AspectFit };

            embeddedImage.Source = ImageSource.FromResource("WorkingWithImages.beach.jpg", typeof(EmbeddedImages).GetTypeInfo().Assembly);

            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Recurso embutido C#",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center
                    },

                    embeddedImage,
                    new Label
                    { Text = "Esta imagem é um recurso incorporado e referenciado."}                    
                },
                Margin = new Thickness(20,35,20,20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
                
            };
        }
    }
}
