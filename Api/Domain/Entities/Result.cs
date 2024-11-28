namespace Api.Domain.Entities
{
    public class Result
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
    }

    public class ResultBuilder
    {
        private Result _result = new Result();
        public ResultBuilder setId(Guid id)
        {
            _result.Id = id;
            return this;
        }
        public ResultBuilder setTitle(string title)
        {
            _result.Title = title;
            return this;
        }

        public ResultBuilder setType(string type)
        {
            _result.Type = type;
            return this;
        }

        public ResultBuilder setCreatedAt(DateTime createdAt)
        {
            _result.createdAt = createdAt;
            return this;
        }

        public Result build()
        {
            return _result;
        }

    }
}
