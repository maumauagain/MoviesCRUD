using System;
using Api.Domain.DTO.Genre;
using Api.Domain.Entities;

namespace Api.Domain.DTO.Movie
{
    public class MovieDTOCompleto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int? Year { get; set; }
        public DateTime CreateAt { get; set; }
        public GenreDTO Genre { get; set; }
    }
}
