using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CA_Imagens
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //Exemplo em C#
            var csharpTab = new TabbedPage();
            csharpTab.Children.Add(new LocalImages { Title = "Local", IconImageSource = "csharp.png" });
            csharpTab.Children.Add(new DownloadImages { Title = "Download", IconImageSource = "csharp.png" });
            csharpTab.Children.Add(new EmbeddedImages { Title = "Embedded", IconImageSource = "csharp.png" });


            //Exemplo em Xaml
            var xamlTab = new TabbedPage();
            xamlTab.Children.Add(new LocalImagesXaml { Title = "Local", IconImageSource = "xaml.png" });
            xamlTab.Children.Add(new DownloadImagesXaml { Title = "Downloaded", IconImageSource = "xaml.png" });
            xamlTab.Children.Add(new EmbeddedImagesXaml { Title = "Embedded", IconImageSource = "xaml.png" });

            //MainPage = csharpTab;
            MainPage = xamlTab;
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
