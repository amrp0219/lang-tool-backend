using Api.Domain.Entities;
using Api.Domain.Repositories.VocabularyInterface;
using Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Domain.Repositories.VocabularyRespository
{
    public class VocabularyRepository : IVocabularyRepository
    {
        private ApplicationDBContext _db;
        public VocabularyRepository(ApplicationDBContext context)
        {
            _db = context;
        }

        public async Task<List<Vocabulary>> search(string lowerSearchText)
        {
            return await _db.Vocabulary.Where(t => 
                EF.Functions.ILike(t.Title, $"%{lowerSearchText}%")
            ).ToListAsync();
        }
    }
}
