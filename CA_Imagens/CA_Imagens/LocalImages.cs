using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CA_Imagens
{
    public class LocalImages : ContentPage
    {
        public LocalImages()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(20, 35, 20, 20),
                Children =
                {
                    new Label { Text = "Image FileSource C#", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center},
                    new Image{ Source = "waterfront.jpg"},
                    new Label { Text = "A imagem foi adicionada a cada projeto de aplicativo. No iOS e Android, " +
                    "várias resoluções são fornecidas e resolvidas em tempo de execução, " +
                    "pelas convenções de nomenclatura da plataforma."}
                }
            };
        }
    }
}
