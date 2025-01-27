using AutoMapper;
using e_Scrap.Models.Common.GasCooker;
using eScrap.Repository;

namespace Services.MediaGalaxy.GasCooker
{
    public class MediaGalaxyGasCookerService : IMediaGalaxyGasCookerService
    {
        private readonly IMediaGalaxyGasCookerRepository _mediaGalaxyGasCookerRepository;
        private readonly IMediaGalaxyGasCookerEmbeddedRepository _mediaGalaxyGasCookerEmbeddedRepository;
        private readonly IMediaGalaxyOvenEmbeddedRepository _mediaGalaxyOvenEmbeddedRepository;
        private readonly IMediaGalaxyOvenEmbeddedRepository _mediaGalaxyHoodRepository;
        private readonly IMapper _mapper;

        public MediaGalaxyGasCookerService(IMediaGalaxyGasCookerRepository mediaGalaxyGasCookerRepository, 
            IMediaGalaxyGasCookerEmbeddedRepository mediaGalaxyGasCookerEmbeddedRepository, 
            IMediaGalaxyOvenEmbeddedRepository mediaGalaxyOvenEmbeddedRepository, 
            IMediaGalaxyOvenEmbeddedRepository mediaGalaxyHoodRepository, IMapper mapper)
        {
            _mediaGalaxyGasCookerRepository = mediaGalaxyGasCookerRepository;
            _mediaGalaxyGasCookerEmbeddedRepository = mediaGalaxyGasCookerEmbeddedRepository;
            _mediaGalaxyOvenEmbeddedRepository = mediaGalaxyOvenEmbeddedRepository;
            _mediaGalaxyHoodRepository = mediaGalaxyHoodRepository;
            _mapper = mapper;
        }

        public async Task<List<GasCookerModel>> GetMediaGalaxyGasCooker()
        {
            var resultProducts = await _mediaGalaxyGasCookerRepository.GetAllProductsAsync();
            return _mapper.Map<List<GasCookerModel>>(resultProducts);
        }
        public async Task<List<GasCookerModel>> GetMediaGalaxyGasCookerEmbedded()
        {
            var resultProducts = await _mediaGalaxyGasCookerEmbeddedRepository.GetAllProductsAsync();
            return _mapper.Map<List<GasCookerModel>>(resultProducts);
        }
        public async Task<List<GasCookerModel>> GetMediaGalaxyHood()
        {
            var resultProducts = await _mediaGalaxyHoodRepository.GetAllProductsAsync();
            return _mapper.Map<List<GasCookerModel>>(resultProducts);
        }
        public async Task<List<GasCookerModel>> GetMediaGalaxyOvenEmbedded()
        {
            var resultProducts = await _mediaGalaxyOvenEmbeddedRepository.GetAllProductsAsync();
            return _mapper.Map<List<GasCookerModel>>(resultProducts);
        }
    }
}
