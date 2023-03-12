using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exercicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularAreaTriangulo : ContentPage
    {
        public CalcularAreaTriangulo()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            Double vBase = Convert.ToDouble(eBase.Text);
            Double vAltura = Convert.ToDouble(eAltura.Text);
            Double total = (vBase * vAltura) / 2;
            lTotal.Text = "A área do triângulo é:" + total.ToString();
        }
    }
}