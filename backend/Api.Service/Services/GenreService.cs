using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using AutoMapper;

namespace Api.Service.Services
{
    public class GenreService : IGenreService
    {
        private IRepository<GenreEntity> _repository;
        private IMapper _mapper;

        public GenreService(IRepository<GenreEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GenreEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<GenreEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

    }
}
