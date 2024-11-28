namespace Api.Domain.Entities
{
    public class Vocabulary
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public Vocabulary(Guid id, string title, DateTime createdAt)
        {
            Id = id;
            Title = title;
            CreatedAt = createdAt;
        }

    }
}
