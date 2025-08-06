using appLogin.Models;

namespace appLogin.Repository.Contract
{
    public interface IClienteRepository
    {
        Cliente Login(string Email, string Senha);
        void Cadastrar(Cliente cliente);
        void Atualizar (Cliente cliente);

        void Ativar (int Id);
        void Desativar (int Id);
        void Excluir (int Id); 
        Cliente ObterCliente (int Id);

        Cliente BuscaCpfCliente(string CPF);

        Cliente BuscaEmailCliente(string Email);

        IEnumerable<Cliente> ObterTodosClientes();
        
    }
}
