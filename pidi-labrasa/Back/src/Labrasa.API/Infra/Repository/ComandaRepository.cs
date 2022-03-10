using Labrasa.API.Domain.Interfaces;
using Labrasa.API.Domain.Models;

namespace Labrasa.API.Infra.Repository
{
    public class ComandaRepository : IComandaRepository
    {
        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comanda> Atualizar(Comanda comanda)
        {
            throw new NotImplementedException();
        }

        public Task<Comanda> Incluir(Comanda comanda)
        {
            throw new NotImplementedException();
        }

        public Task<Comanda> PegarPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comanda>> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
