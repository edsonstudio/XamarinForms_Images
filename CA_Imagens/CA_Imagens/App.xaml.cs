using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CA_Imagens
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Exemplo em C#
            var csharpTab = new TabbedPage();
            csharpTab.Children.Add(new LocalImages
            {
                Title = "Local",
                IconImageSource = "csharp.png"
            });

            csharpTab.Children.Add(new DownloadImages { 
                Title = "Download", 
                IconImageSource = "csharp.png"
            });

            csharpTab.Children.Add(new EmbeddedImages
            {
                Title = "Embedded",
                IconImageSource = "csharp.png"
            });

            MainPage = csharpTab;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
