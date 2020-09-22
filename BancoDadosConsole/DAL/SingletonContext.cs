using BancoDadosConsole.Models;

namespace BancoDadosConsole.DAL
{
    class SingletonContext
    {
        private static Context _context;
        public static Context GetInstance()
        {
            if (_context == null)
            {
                _context = new Context();
            }
            return _context;
        }
    }
}
