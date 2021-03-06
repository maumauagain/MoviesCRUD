using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTO.Movie;

namespace Api.Domain.Interfaces.Services
{
    public interface IMovieService
    {
        Task<MovieDTOCompleto> Get(Guid id);
        Task<IEnumerable<MovieDTOCompleto>> GetAll();
        Task<MovieDTO> Post(MovieDTOCreate movie);
        Task<MovieDTO> Put(MovieDTOUpdate movie);
        Task<bool> Delete(Guid id);
    }
}
