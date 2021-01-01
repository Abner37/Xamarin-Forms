using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQtde
{
    public partial class MainPage : ContentPage
    {
        private int qtde = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Aumentar(object sender, EventArgs e)
        {
            qtde++;
            LblQtde.Text = qtde.ToString();
        }
        private void Diminuir(object sender, EventArgs e)
        {
            if (qtde != 0)
            {
                qtde--;
                LblQtde.Text = qtde.ToString();
            }
        }
    }
}
