using Api.Domain.DTO.Genre;
using Api.Domain.DTO.Movie;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings.Movie
{
    public class EntityToDTOProfile : Profile
    {
        public EntityToDTOProfile()
        {
            CreateMap<MovieEntity, MovieDTO>()
                .ReverseMap();
            CreateMap<MovieEntity, MovieDTOCompleto>()
                .ReverseMap();
            CreateMap<GenreEntity, GenreDTO>()
                .ReverseMap();
        }
    }
}
