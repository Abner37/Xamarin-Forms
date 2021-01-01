using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetMarcas();
        }

        public List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFIAT(),
                GetListaCarrosFORD()
            };
        }
        private Marca GetListaCarrosFORD()
        {
            var ford = new Marca()
            {
                new Carro
                {
                    Nome = "KA",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Um carro da FORD de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "KA Sedan",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Um carro da FORD de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Fusion",
                    Motorizacao = "2.0 - 2.4",
                    Descricao = "Um carro da FORD de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "EcoSport",
                    Motorizacao = "1.8 - 2.0",
                    Descricao = "Um carro da FORD admirado pelo mercado.",
                    ItensDeSerie = "Air-bags, Direção elétrica, Ar-condicionado"
                },
                new Carro
                {
                    Nome = "Novo Edge",
                    Motorizacao = "2.4 - 3.0",
                    Descricao = "Um carro da FORD de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Ranger",
                    Motorizacao = "3.2",
                    Descricao = "Uma caminhote da FORD de luxo.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Mustang",
                    Motorizacao = "5.0",
                    Descricao = "Um carro da FORD de luxo e esportivo.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                }
            };

            ford.Nome = "FORD";

            return ford;
        }
        private Marca GetListaCarrosFIAT()
        {
            var fiat = new Marca()
            {
                new Carro
                {
                    Nome = "Mobi",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um autêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusivamente para seu design único.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Uno",
                    Motorizacao = "1.0",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Cronos",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Toro",
                    Motorizacao = "1.8, 2.4 e 2.0TD",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção elétrica, Ar-condicionado"
                },
                new Carro
                {
                    Nome = "Grand Siena",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Strada",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Dublo",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "Um carro da FIAT de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                }
            };

            fiat.Nome = "FIAT";

            return fiat;
        }
        private Marca GetListaCarrosRENAULT()
        {
            var renault = new Marca()
            {
                new Carro
                {
                    Nome = "Kwid",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Kwid Way. O Kit Cross transforma seu Kwid em um autêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusivamente para seu design único.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Sandero",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "Um carro da Renault de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Logan",
                    Motorizacao = "1.6",
                    Descricao = "Um carro da Renault de qualidade.",
                    ItensDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Duster",
                    Motorizacao = "1.6, 2.0",
                    Descricao = "Um carro da Renault de qualidade.",
                    ItensDeSerie = "Air-bags, Direção elétrica, Ar-condicionado"
                }
            };

            renault.Nome = "RENAULT";

            return renault;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro)parametro;
            DisplayAlert("Clicou no Visualizar", $"Registro: {carro.Nome}", "OK");
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            var marcas = new List<Marca>()
            {
                GetListaCarrosRENAULT()
            };
            Lista01.ItemsSource = marcas;
            Lista01.EndRefresh();
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            lblScroll.Text = $"X: {e.ScrollX} | Y: {e.ScrollY}";
        }

        private void MoverParaFordKa(object sender, EventArgs e)
        {
            try
            {
                var marcas = (List<Marca>)Lista01.ItemsSource;
                var ford = marcas[1];
                var ka = ford[0];
                Lista01.ScrollTo(ka, ScrollToPosition.Center, true);
            }
            catch (Exception)
            {
                // None
            }
        }

        private void Lista01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Toda vez que o evento ItemSelected é disparado, o item selecionado é armazenado na propriedade SelectedItem
            var carro = (Carro)Lista01.SelectedItem;
            DisplayAlert("Selecionado", carro.Nome + " selecionado", "OK");
        }

        private void Lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Tocado", "Item tocado", "OK");
        }
    }

    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItensDeSerie { get; set; }
    }

    public class Marca : List<Carro>
    {
        public string Nome { get; set; }
    }
}