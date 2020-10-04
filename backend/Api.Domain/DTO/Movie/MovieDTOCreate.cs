using System.ComponentModel.DataAnnotations;
using Api.Domain.Entities;

namespace Api.Domain.DTO.Movie
{
    public class MovieDTOCreate
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Título deve ter no máximo 60 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Diretor deve ter no máximo 60 caracteres")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public GenreEntity Genre { get; set; }

        [MaxLength(500, ErrorMessage = "Sinopse deve ter no máximo 500 caracteres")]
        public string Synopsis { get; set; }

        [MaxLength(4, ErrorMessage = "Ano de estréia deve ter no máximo 4 caracteres")]
        public int Year { get; set; }
    }
}
