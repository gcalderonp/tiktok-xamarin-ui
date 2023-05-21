using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTok.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TikTok.Vistas.Reproductor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VReproductor : ContentPage
    {
        public VReproductor()
        {
            InitializeComponent();
            BindingContext = new VMReproductor(Navigation);
        }
    }
}