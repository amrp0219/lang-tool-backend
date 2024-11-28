using Api.Domain.Entities;

namespace Api.Application.UseCases.GetResults
{
    public interface IGetSearchResults
    {
        Task<List<Result>> GetSearchResults(string text);
    }
}
