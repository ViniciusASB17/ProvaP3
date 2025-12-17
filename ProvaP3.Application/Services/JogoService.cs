
using ProvaP3.Application.Interfaces;
using ProvaP3.Dominio.Entidades;
using ProvaP3.Dominio.Interfaces;

namespace ProvaP3.Application.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _repository;

        public JogoService(IJogoRepository repository)
        {
            _repository = repository;
        }

        public void Registrar(Jogo jogo)
        {
            _repository.Registrar(jogo);
        }

        public List<Jogo> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
