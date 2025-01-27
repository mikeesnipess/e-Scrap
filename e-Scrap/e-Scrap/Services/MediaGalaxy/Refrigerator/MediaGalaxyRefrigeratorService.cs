using AutoMapper;
using eScrap.Repository;
using Models.Common.Refrigerator;

namespace Services.MediaGalaxy.Refrigerator
{
    public class MediaGalaxyRefrigeratorService : IMediaGalaxyRefrigeratorService
    {
        private readonly IMediaGalaxyRefrigeratorRepository _mediaGalaxyRefrigeratorRepository;
        private readonly IMapper _mapper;
        public MediaGalaxyRefrigeratorService(IMediaGalaxyRefrigeratorRepository mediaGalaxyRefrigeratorRepository, IMapper mapper)
        {
            _mediaGalaxyRefrigeratorRepository = mediaGalaxyRefrigeratorRepository;
            _mapper = mapper;
        }

        public async Task<List<RefrigeratorModel>> GetMediaGalaxyRefrigerator()
        {
            var resultProducts = await _mediaGalaxyRefrigeratorRepository.GetAllProductsAsync();
            return _mapper.Map<List<RefrigeratorModel>>(resultProducts);
        }
    }
}
