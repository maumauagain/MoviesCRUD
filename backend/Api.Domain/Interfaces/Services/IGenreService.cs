using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IGenreService
    {
        Task<GenreEntity> Get(Guid id);
        Task<IEnumerable<GenreEntity>> GetAll();
    }
}
