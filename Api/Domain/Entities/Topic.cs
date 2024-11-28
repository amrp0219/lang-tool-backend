namespace Api.Domain.Entities
{
    public class Topic
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Topic(Guid id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
