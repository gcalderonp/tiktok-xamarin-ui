using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TikTok.Vistas.Reproductor;

namespace TikTok
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VReproductor();
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
