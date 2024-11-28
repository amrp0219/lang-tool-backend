using Api.Domain.Entities;

namespace Api.Domain.Repositories.TopicRepository
{
    public interface ITopicsRepository
    {
        Task<List<Topic>> search(string searchText);
    }
}
