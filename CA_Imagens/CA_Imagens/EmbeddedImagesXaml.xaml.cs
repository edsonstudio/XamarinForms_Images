using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CA_Imagens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImagesXaml : ContentPage
    {
        public EmbeddedImagesXaml()
        {
            InitializeComponent();

            var assembly = typeof(EmbeddedImages).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
        }
    }
}