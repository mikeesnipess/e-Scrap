using AutoMapper;
using eScrap.Repository;
using Models.Common.Refrigerator;

namespace Services.Altex.Refrigerator
{
    public class AltexRefrigeratorService : IAltexRefrigeratorService
    {
        private readonly IAltexRefrigeratorRepository _refrigeratorRepository;
        private readonly IMapper _mapper;

        public AltexRefrigeratorService(IAltexRefrigeratorRepository refrigeratorRepository, IMapper mapper)
        {
            _refrigeratorRepository = refrigeratorRepository;
            _mapper = mapper;
        }

        public async Task<List<RefrigeratorModel>> GetAltexRefrigerator()
        {
            var resultProducts = await _refrigeratorRepository.GetAllProductsAsync();
            return _mapper.Map<List<RefrigeratorModel>>(resultProducts);
        }
    }
}
