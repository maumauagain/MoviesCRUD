using System;

namespace Api.Domain.Entities
{
    public class MovieEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public Guid GenreId { get; set; }
        public GenreEntity Genre { get; set; }
        public string Synopsis { get; set; }
        public int? Year { get; set; }
    }
}
