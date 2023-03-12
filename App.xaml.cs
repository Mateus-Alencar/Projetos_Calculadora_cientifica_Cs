using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exercicios
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcularFatorialDeUmNumero();
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
