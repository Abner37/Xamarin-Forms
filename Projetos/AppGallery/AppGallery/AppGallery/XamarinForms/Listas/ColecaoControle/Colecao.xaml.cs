using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ColecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colecao : ContentPage
    {
        private ObservableCollection<Categoria> categorias { get; set; }

        public Colecao()
        {
            InitializeComponent();

            //Colecao01.ItemsSource = GetFastFoods();
            //Colecao01.ItemsSource = new List<FastFood>();
            Colecao01.ItemsSource = GetCategorias();
        }

        private ObservableCollection<Categoria> GetCategorias()
        {
            categorias = new ObservableCollection<Categoria>();

            var lanches = new Categoria()
            {
                new FastFood() { Nome = "Subway", QtdeDeFranquias = 44834 },
                new FastFood() { Nome = "MacDonald's", QtdeDeFranquias = 37000 },
                new FastFood() { Nome = "Burguer King", QtdeDeFranquias = 15000 }
            };
            lanches.Nome = "Lanches";

            var pizzarias = new Categoria()
            {
                new FastFood() { Nome = "Pizza Hut", QtdeDeFranquias = 15000 },
                new FastFood() { Nome = "Domino`s", QtdeDeFranquias = 15000 }
            };
            pizzarias.Nome = "Pizzarias";

            var outros = new Categoria()
            {
                new FastFood() { Nome = "Starbucks", QtdeDeFranquias = 27000 },
                new FastFood() { Nome = "KFC", QtdeDeFranquias = 19000 },
                new FastFood() { Nome = "Baskin-Robbins", QtdeDeFranquias = 7500 },
                new FastFood() { Nome = "Taco Bell", QtdeDeFranquias = 7000 },
            };
            outros.Nome = "Outros";

            categorias.Add(lanches);
            categorias.Add(pizzarias);
            categorias.Add(outros);

            return categorias;
        }

        private List<FastFood> GetFastFoods()
        {
            return new List<FastFood>()
            {
                new FastFood() { Nome = "Subway", QtdeDeFranquias = 44834 },
                new FastFood() { Nome = "MacDonald's", QtdeDeFranquias = 37000 },
                new FastFood() { Nome = "Starbucks", QtdeDeFranquias = 27000 },
                new FastFood() { Nome = "KFC", QtdeDeFranquias = 19000 },

                new FastFood() { Nome = "Burguer King", QtdeDeFranquias = 15000 },
                new FastFood() { Nome = "Pizza Hut", QtdeDeFranquias = 15000 },
                new FastFood() { Nome = "Baskin-Robbins", QtdeDeFranquias = 7500 },
                new FastFood() { Nome = "Taco Bell", QtdeDeFranquias = 7000 }
            };
        }

        private void Colecao01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            var restaurantes = new Categoria()
            {
                new FastFood() { Nome = "Marmitex", QtdeDeFranquias = 10 },
                new FastFood() { Nome = "Jhon Hamburgues", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Mix", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Marietta", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Churrascaria Brasil", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Churrascaria São Paulo", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Churrascaria Gaucha", QtdeDeFranquias = 2 },
                new FastFood() { Nome = "Churrascaria Palmeiras", QtdeDeFranquias = 2 }
            };
            restaurantes.Nome = "Restaurantes";

            categorias.Add(restaurantes);
        }
    }

    public class FastFood
    {
        public string Nome { get; set; }
        public int QtdeDeFranquias { get; set; }
    }

    public class Categoria : List<FastFood>
    {
        public string Nome { get; set; }
    }
}