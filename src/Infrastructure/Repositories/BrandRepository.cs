using GLifeInc.Application.Interfaces.Repositories;
using GLifeInc.Domain.Entities.Catalog;

namespace GLifeInc.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}