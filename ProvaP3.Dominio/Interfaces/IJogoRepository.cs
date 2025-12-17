
using ProvaP3.Dominio.Entidades;

namespace ProvaP3.Dominio.Interfaces
{
    public interface IJogoRepository
    {
        void Registrar(Jogo jogo);
        List<Jogo> ObterTodos();
    }
}
