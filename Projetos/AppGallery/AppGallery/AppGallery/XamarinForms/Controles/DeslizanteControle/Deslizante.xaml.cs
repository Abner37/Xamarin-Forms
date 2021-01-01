using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.DeslizanteControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deslizante : ContentPage
    {
        public Deslizante()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValueChanged.Text = "Valor antigo: " + e.OldValue + " | Valor novo: " + e.NewValue;
        }
        private void Slider_DragStarted(object sender, EventArgs e)
        {
            lblDragStarted.Text = "Iniciou o arrasto";
        }
        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            lblDragCompleted.Text = "Terminou de arrastar";
        }

        private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            int passos = 5;
            double novoPasso = Math.Round(e.NewValue / passos);
            ((Slider)sender).Value = novoPasso * passos;

            lblValueChanged_Step.Text = ((Slider)sender).Value.ToString();
        }
    }
}