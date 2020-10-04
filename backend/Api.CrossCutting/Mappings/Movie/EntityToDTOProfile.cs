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
        }
    }
}
