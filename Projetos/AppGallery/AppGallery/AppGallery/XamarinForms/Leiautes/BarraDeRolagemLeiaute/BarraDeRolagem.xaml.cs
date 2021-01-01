using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Leiautes.BarraDeRolagemLeiaute
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarParaSegundaLabel(object sender, EventArgs e)
        {
            BarraDeRolagemScroll.ScrollToAsync(SegundaLabel, ScrollToPosition.Start, true);
        }
        private void RolarParaCima(object sender, EventArgs e)
        {
            BarraDeRolagemScroll.ScrollToAsync(0, 0, true);
        }

        private void OutroExemplo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BarraDeRolagem2());
        }
    }
}