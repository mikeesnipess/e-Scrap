using AutoMapper;
using eScrap.Models.Common.Laptop;
using eScrap.Repository;

namespace eScrap.Services.MediaGalaxy.Laptop
{
    public class MediaGalaxyLaptopService : IMediaGalaxyLaptopService
    {
        private readonly IMediaGalaxyLaptopRepository _mediaGalaxyLaptopRepository;
        private readonly IMapper _mapper;

        public MediaGalaxyLaptopService(IMediaGalaxyLaptopRepository mediaGalaxyLaptopRepository, IMapper mapper)
        {
            _mediaGalaxyLaptopRepository = mediaGalaxyLaptopRepository;
            _mapper = mapper;
        }

        public async Task<List<LaptopModel>> GetProductListAsync()
        {
            var resultProducts = await _mediaGalaxyLaptopRepository.GetAllProductsAsync();
            return _mapper.Map<List<LaptopModel>>(resultProducts);
        }
    }
}
