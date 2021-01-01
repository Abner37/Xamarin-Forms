using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.BotaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Botao : ContentPage
    {
        public Botao()
        {
            InitializeComponent();
        }

        private void Clicado_Clicked(object sender, EventArgs e)
        {
            LblClicado.Text = LblClicado.Text == "-" ? "Clicado" : "-";
        }
        private void Pressionado_Pressed(object sender, EventArgs e)
        {
            LblPressionado.Text = LblPressionado.Text == "-" ? "Pressionado" : "-";
        }
        private void Liberado_Released(object sender, EventArgs e)
        {
            LblLiberado.Text = LblLiberado.Text == "-" ? "Liberado" : "-";
        }
    }
}