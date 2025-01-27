using AutoMapper;
using e_crap.Models.Common.WashMachine;
using eScrap.Repository;

namespace Services.Altex.WashMachine
{
    public class AltexWashMachineService : IAltexWashMachineService
    {
        private readonly IAltexWashMachineRepository _washMachineRepository;
        private readonly IMapper _mapper;

        public AltexWashMachineService(IAltexWashMachineRepository washMachineRepository, IMapper mapper)
        {
            _washMachineRepository = washMachineRepository;
            _mapper = mapper;
        }

        public async Task<List<WashMachineModel>> GetAltexWashMachine()
        {
            var resultProducts = await _washMachineRepository.GetAllProductsAsync();
            return _mapper.Map<List<WashMachineModel>>(resultProducts);
        }
    }
}
