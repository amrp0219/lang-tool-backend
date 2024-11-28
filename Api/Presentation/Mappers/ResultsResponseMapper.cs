using Api.Domain.Entities;
using Api.Presentation.Dtos;

namespace Api.Presentation.Mappers
{
    public static class ResultsResponseMapper
    {
        public static ResultsResponseDto toResultsResponseDto(this Result resultResponse)
        {
            return new ResultsResponseDto
            {
                Id = resultResponse.Id,
                Title = resultResponse.Title,
                Type = resultResponse.Type,
                createdAt = resultResponse.createdAt
            };
        }
    }
}
