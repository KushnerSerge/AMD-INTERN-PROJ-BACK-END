using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class IngredientService : IIngredientService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public IngredientService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<IngredientDto> CreateIngredientAsync(IngredientForCreationDto company)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIngredientAsync(Guid mealId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IngredientDto>> GetAllIngredientsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IngredientDto> GetIngredientAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
