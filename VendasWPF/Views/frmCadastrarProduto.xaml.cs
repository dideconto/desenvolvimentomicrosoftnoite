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
            btnCadastrar.IsEnabled = true;
            btnAlterar.IsEnabled = false;
            btnRemover.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                produto = ProdutoDAO.BuscarPorNome(txtNome.Text);
                if (produto != null)
                {
                    btnCadastrar.IsEnabled = false;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;

                    txtId.Text = produto.Id.ToString();
                    txtNome.Text = produto.Nome;
                    txtQuantidade.Text = produto.Quantidade.ToString();
                    txtPreco.Text = produto.Preco.ToString();
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

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (produto != null)
            {
                ProdutoDAO.Remover(produto);
                MessageBox.Show("O produto foi removido com sucesso!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("O produto não foi removido!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (produto != null)
            {
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDouble(txtPreco.Text);
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                ProdutoDAO.Alterar(produto);
                MessageBox.Show("O produto foi alterado com sucesso!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("O produto não foi alterado!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }
    }
}
