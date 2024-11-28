using Api.Domain.Entities;

namespace Api.Domain.Repositories.VocabularyInterface
{
    public interface IVocabularyRepository
    {
        Task<List<Vocabulary>> search(string lowerSearchText);
    }
}
