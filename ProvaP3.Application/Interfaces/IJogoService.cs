
using ProvaP3.Dominio.Entidades;

namespace ProvaP3.Application.Interfaces
{
    public interface IJogoService
    {
        void Registrar(Jogo jogo);
        List<Jogo> ObterTodos();
    }
}
