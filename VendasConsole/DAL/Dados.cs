using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Diogo Deconto",
                Cpf = "05363419904"
            };
            ClienteDAO.Cadastrar(cliente);
            Vendedor vendedor = new Vendedor
            {
                Nome = "José da Silva",
                Cpf = "05363419904"
            };
            VendedorDAO.Cadastrar(vendedor);
            Produto produto = new Produto
            {
                Nome = "Bolacha",
                Preco = 3.75,
                Quantidade = 150
            };
            ProdutoDAO.Cadastrar(produto);
        }
    }
}
