using Api.Domain.Entities;
using Api.Domain.Repositories.TopicRepository;
using Api.Domain.Repositories.VocabularyInterface;

namespace Api.Application.UseCases.GetResults
{
    public class GetSearchResultsUseCase : IGetSearchResults
    {
        private readonly IVocabularyRepository _vocabularyRepository;
        private readonly ITopicsRepository _topicsRepository;
        public GetSearchResultsUseCase(ITopicsRepository topicsRepository, IVocabularyRepository vocabularyRepository)
        {
            _vocabularyRepository = vocabularyRepository;
            _topicsRepository = topicsRepository;
        }

        public async Task<List<Result>> GetSearchResults(string text)
        {
            List<Topic> topics = await _topicsRepository.search(text);
            List<Vocabulary> vocabularyList = await _vocabularyRepository.search(text);
            List<Result> results = new List<Result>();

            foreach (Topic topic in topics)
            {
                ResultBuilder resultBuilder = new ResultBuilder();
                results.Add
                    (
                        resultBuilder
                            .setType("TOPIC")
                            .setId(topic.Id)
                            .setTitle(topic.Title)
                            .setCreatedAt(topic.CreatedAt)
                            .build()
                    );
            }

            foreach (Vocabulary vocabulary in vocabularyList)
            {
                ResultBuilder resultBuilder = new ResultBuilder();
                results.Add
                    (
                        resultBuilder
                            .setType("VOCABULARY")
                            .setId(vocabulary.Id)
                            .setTitle(vocabulary.Title)
                            .setCreatedAt(vocabulary.CreatedAt)
                            .build()
                    );

            }

            results = results.OrderByDescending(result => result.createdAt).ToList();

            return results;

        }
    }
}
