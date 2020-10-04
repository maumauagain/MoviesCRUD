using Api.Domain.DTO.Movie;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings.Movie
{
    public class DTOToModelProfile : Profile
    {
        public DTOToModelProfile()
        {
            CreateMap<MovieModel, MovieDTOCreate>()
                .ReverseMap();

            CreateMap<MovieModel, MovieDTOUpdate>()
                .ReverseMap();
        }

    }
}
