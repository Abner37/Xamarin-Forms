using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.BarraDeProgressoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeProgresso : ContentPage
    {
        double progress = 0;

        public BarraDeProgresso()
        {
            InitializeComponent();
        }

        private void BtnProcessar_Clicked(object sender, EventArgs e)
        {
            progress += 0.1;
            barraDeProgresso.ProgressTo(progress, 500, Easing.Linear);
        }
    }
}