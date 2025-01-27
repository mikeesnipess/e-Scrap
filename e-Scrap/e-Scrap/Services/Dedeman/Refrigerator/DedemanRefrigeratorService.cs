using AutoMapper;
using eScrap.Repository;
using Models.Common.Refrigerator;

namespace Services.Dedeman.Refrigerator
{
    public class DedemanRefrigeratorService : IDedemanRefrigeratorService
    {
        private readonly IDedemanRefrigeratorRepository _dedemanRefrigeratorRepository;
        private readonly IMapper _mapper;

        public DedemanRefrigeratorService(IDedemanRefrigeratorRepository dedemanRefrigeratorRepository, IMapper mapper)
        {
            _dedemanRefrigeratorRepository = dedemanRefrigeratorRepository;
            _mapper = mapper;
        }

        public async Task<List<RefrigeratorModel>> GetAltexRefrigerator()
        {
            var resultProducts = await _dedemanRefrigeratorRepository.GetAllProductsAsync();
            return _mapper.Map<List<RefrigeratorModel>>(resultProducts);
        }
    }
}
