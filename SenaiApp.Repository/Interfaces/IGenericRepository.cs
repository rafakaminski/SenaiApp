using SenaiApp.Domain.Entidade;

namespace SenaiApp.Repository.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        void Remover(long id);
    }
}