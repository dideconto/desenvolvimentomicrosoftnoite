using System;
using System.Windows;
using VendasWPF.DAL;
using VendasWPF.Models;

namespace VendasWPF.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {

        private Produto produto;
        public frmCadastrarProduto()
        {
            InitializeComponent();
            txtNome.Focus();
        }
        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                produto = new Produto
                {
                    Nome = txtNome.Text,
                    Preco = Convert.ToDouble(txtPreco.Text),
                    Quantidade = Convert.ToInt32(txtQuantidade.Text)
                };
                if (ProdutoDAO.Cadastrar(produto))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!!!", "Vendas WPF",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Esse produto já existe!!!", "Vendas WPF",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtCriadoEm.Clear();
            txtNome.Focus();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                produto = ProdutoDAO.BuscarPorNome(txtNome.Text);
                if (produto != null)
                {
                    txtId.Text = produto.Id.ToString();
                    txtNome.Text = produto.Nome;
                    txtQuantidade.Text = produto.Quantidade.ToString();
                    txtPreco.Text = produto.Preco.ToString(); ;
                    txtCriadoEm.Text = produto.CriadoEm.ToString();
                }
                else
                {
                    MessageBox.Show("Esse produto não existe!!!", "Vendas WPF",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
