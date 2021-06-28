using GLifeInc.Application.Interfaces.Repositories;
using GLifeInc.Domain.Entities.Misc;

namespace GLifeInc.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}