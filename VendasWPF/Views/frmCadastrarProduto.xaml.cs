using System;
using System.Windows;

namespace VendasWPF.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }
        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            //txtNumero1.Text = "Teste Teste Teste";
            int n1 = Convert.ToInt32(txtNumero1.Text);
            int n2 = Convert.ToInt32(txtNumero2.Text);
            int soma = n1 + n2;
            MessageBox.Show($"Soma: {soma}");
        }
    }
}
