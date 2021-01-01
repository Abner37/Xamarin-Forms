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
    public partial class BarraDeRolagem2 : ContentPage
    {
        public BarraDeRolagem2()
        {
            InitializeComponent();
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Posicao.Text = $"Scroll... X: {e.ScrollX:N2} | Y: {e.ScrollY:N2}";
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();
            }
            catch (InvalidOperationException)
            {
                // None
            }
        }
    }
}