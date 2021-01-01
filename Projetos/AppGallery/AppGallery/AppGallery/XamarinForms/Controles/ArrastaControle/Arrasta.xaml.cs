using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ArrastaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void SwipeVisualizar_Invoked(object sender, EventArgs e)
        {
            lblVisualizarProduto.Text = "Acionado visualizar produto : " + DateTime.Now.ToString("HH:mm:ss");
        }
        private void SwipeDetalhe_Invoked(object sender, EventArgs e)
        {
            lblDetalhe.Text = "Acionado detalhe : " + DateTime.Now.ToString("HH:mm:ss");
        }
        private void SwipeExcluir_Invoked(object sender, EventArgs e)
        {
            lblExcluir.Text = "Acionado excluir : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            lblStarted.Text = $"Acionado SwipeStarted : {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}";
        }
        private void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            lblChaging.Text = $"Acionado SwipeChanging : {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}:{e.Offset}";
        }
        private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblEnded.Text = $"Acionado SwipeEnded : {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}";
        }

        private void SwipeView_CloseRequested(object sender, EventArgs e)
        {
            lblClose.Text = $"SwipeView fechado : {DateTime.Now:HH:mm:ss}";
        }
        private void FecharSwipeView_Clicked(object sender, EventArgs e)
        {
            swipeView.Close();
        }
    }
}