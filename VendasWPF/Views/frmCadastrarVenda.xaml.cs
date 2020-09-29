using System;
using System.Collections.Generic;
using System.Windows;
using VendasWPF.DAL;
using VendasWPF.Models;

namespace VendasWPF.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarVenda.xaml
    /// </summary>
    public partial class frmCadastrarVenda : Window
    {
        private List<ItemVenda> itens = new List<ItemVenda>();
        public frmCadastrarVenda()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Carregar os dados de clientes
            cboClientes.ItemsSource = ClienteDAO.Listar();
            cboClientes.DisplayMemberPath = "Nome";
            cboClientes.SelectedValuePath = "Id";

            //Carregar os dados de vendedores
            cboVendedores.ItemsSource = VendedorDAO.Listar();
            cboVendedores.DisplayMemberPath = "Nome";
            cboVendedores.SelectedValuePath = "Id";

            //Carregar os dados de produtos
            cboProdutos.ItemsSource = ProdutoDAO.Listar();
            cboProdutos.DisplayMemberPath = "Nome";
            cboProdutos.SelectedValuePath = "Id";
        }
        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscarPorId(id);
            ItemVenda item = new ItemVenda
            {
                Produto = produto,
                Preco = produto.Preco,
                Quantidade = Convert.ToInt32(txtQuantidade.Text)
            };
            itens.Add(item);
            dtaProdutos.ItemsSource = itens;
            dtaProdutos.Items.Refresh();
        }
    }
}
