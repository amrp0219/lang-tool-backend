using Api.Application.UseCases.GetResults;
using Api.Domain.Entities;
using Api.Presentation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Presentation.Controllers
{
    [Route("api/search")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IGetSearchResults _getSearchResultsUseCase;
        public SearchController(IGetSearchResults getSearchResultsUseCase)
        {
            _getSearchResultsUseCase = getSearchResultsUseCase;
        }
        [HttpGet("{searchText}")]
        public async Task<IActionResult> GetAll([FromRoute] string searchText)
        {
            List<Result> resultsResponse = await _getSearchResultsUseCase.GetSearchResults(searchText);
            var resultsResponseDto = resultsResponse.Select(s => s.toResultsResponseDto());
            return Ok(resultsResponseDto);
        }
    }
}
