﻿namespace Api.Presentation.Dtos
{
    public class ResultsResponseDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
    }
}
