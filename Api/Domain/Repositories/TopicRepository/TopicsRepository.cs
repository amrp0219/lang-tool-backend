using Api.Domain.Entities;
using Api.Domain.Repositories.TopicRepository;
using Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Domain.Repositories.TopicRespository
{
    public class TopicsRepository : ITopicsRepository
    {
        private ApplicationDBContext _db;
        public TopicsRepository(ApplicationDBContext context)
        {
            _db = context;
        }
        public async Task<List<Topic>> search(string searchText)
        {

            string lowerSearchText = searchText.ToLower();

            return await _db.Topics.Where(t => 
                EF.Functions.ILike(t.Title, $"%{lowerSearchText}%") ||
                EF.Functions.ILike(t.Description, $"%{lowerSearchText}%")
            ).ToListAsync();
        }
    }
}
