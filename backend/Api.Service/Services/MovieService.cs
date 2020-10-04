using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTO.Movie;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class MovieService : IMovieService
    {
        private IRepository<MovieEntity> _repository;
        private IMapper _mapper;

        public MovieService(IRepository<MovieEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<MovieDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<MovieDTO>(entity);
        }

        public async Task<IEnumerable<MovieDTO>> GetAll(Guid id)
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<MovieDTO>>(entities);
        }

        public async Task<MovieDTO> Post(MovieDTOCreate movie)
        {
            var model = _mapper.Map<MovieModel>(movie);
            var entity = _mapper.Map<MovieEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<MovieDTO>(result);
        }

        public async Task<MovieDTO> Put(MovieDTOUpdate movie)
        {
            var model = _mapper.Map<MovieModel>(movie);
            var entity = _mapper.Map<MovieEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<MovieDTO>(result);
        }
    }
}
