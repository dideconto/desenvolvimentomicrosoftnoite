using BancoDadosConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoDadosConsole.DAL
{
    class PessoaDAO
    {
        private static Context _context = new Context();
        public static bool Cadastrar(Pessoa pessoa)
        {
            if (BuscarPorEmail(pessoa.Email) == null)
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Pessoa> Listar() => _context.Pessoas.ToList();
        public static Pessoa BuscarPorId(int id) => _context.Pessoas.Find(id);
        public static Pessoa BuscarPorEmail(string email) =>
            _context.Pessoas.FirstOrDefault(x => x.Email == email);
        public static Pessoa BuscarPorEmailUnico(string email)
        {
            try
            {
                return _context.Pessoas.SingleOrDefault(x => x.Email == email);
            }
            catch (Exception)
            {
                throw new Exception("Existem mais elementos na busca!!!");
            }
        }
        public static List<Pessoa> FiltrarPorParteNome(string parteNome) =>
            _context.Pessoas.Where(x => x.Nome.Contains(parteNome)).ToList();
        public static void Alterar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }
        public static void Remover(Pessoa pessoa)
        {
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }
    }
}
