using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace appLogin.Libraries.Sessao
{
    public class Sessao
    {
        IHttpContextAccessor _context;
        public Sessao(IHttpContextAccessor context)
        {
            _context = context;
        }
        public void Cadastrar(string Key, string valor )
        {
            _context.HttpContext.Session.SetString( Key, valor );
        }
        public string Consultar(string Key) 
        {
            return _context.HttpContext.Session.GetString(Key);
        }
        public bool Existe(string Key)
        {
            if (_context.HttpContext.Session.GetString(Key) == null)
            {
                return false;
            }

            return true;
        }
        public void RemoverTodos()
        {
            _context.HttpContext.Session.Clear();
        }
        public void Remover(string Key)
        {
            _context.HttpContext.Session.Remove(Key);
        }
        public void Atualizar(string Key, string valor)
        {
            if (Existe(Key))
            {
                _context.HttpContext.Session.Remove(Key);
            }
            _context.HttpContext.Session.SetString(Key, valor);
        }

    }
}
