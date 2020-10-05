using System;
using Api.Domain.Entities;

namespace Api.Domain.DTO.Movie
{
    public class MovieDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int? Year { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid GenreId { get; set; }
        public virtual GenreEntity Genre { get; set; }
    }
}
