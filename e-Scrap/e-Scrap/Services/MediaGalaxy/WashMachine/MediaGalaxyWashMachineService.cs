using AutoMapper;
using e_crap.Models.Common.WashMachine;
using eScrap.Repository;

namespace Services.MediaGalaxy.WashMachine
{
    public class MediaGalaxyWashMachineService : IMediaGalaxyWashMachineService
    {
        private readonly IMediaGalaxyWashMachineRepository _mediaGalaxyWashMachineRepository;
        private readonly IMapper _mapper;

        public MediaGalaxyWashMachineService(IMediaGalaxyWashMachineRepository mediaGalaxyWashMachineRepository, IMapper mapper)
        {
            _mediaGalaxyWashMachineRepository = mediaGalaxyWashMachineRepository;
            _mapper = mapper;
        }

        public async Task<List<WashMachineModel>> GetMediaGalaxyWashMachine()
        {
            var resultProducts = await _mediaGalaxyWashMachineRepository.GetAllProductsAsync();
            return _mapper.Map<List<WashMachineModel>>(resultProducts);
        }
    }
}
