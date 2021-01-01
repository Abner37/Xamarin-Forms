using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());

            //var pagina = new XamarinForms.Paginas.Modal.Conteudo01();

            //var pagina = new CarouselPage();
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

            //var pagina = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();

            //var pagina = new XamarinForms.Paginas.PaginaDeAbas.Abas();

            //var pagina = new MasterDetailPage();
            //// Menu
            //pagina.Master = new ContentPage();
            //// Conteúdo
            //pagina.Detail = new ContentPage();

            //var pagina = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();

            var pagina = new AppBase.Menu();

            MainPage = pagina;
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
