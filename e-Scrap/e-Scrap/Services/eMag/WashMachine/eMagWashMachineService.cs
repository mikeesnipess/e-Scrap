using AutoMapper;
using e_crap.Models.Common.WashMachine;
using eScrap.Repository;

namespace Services.eMag.WashMachine
{
    public class eMagWashMachineService : IEmagWashMachineService
    {
        private readonly IEMagWashMachineRepository _eMagWashMachineRepository;
        private readonly IMapper _mapper;

        public eMagWashMachineService(IEMagWashMachineRepository eMagWashMachineRepository, IMapper mapper)
        {
            _eMagWashMachineRepository = eMagWashMachineRepository;
            _mapper = mapper;
        }

        public async Task<List<WashMachineModel>> GetWashMachineEMag()
        {
            var resultProducts = await _eMagWashMachineRepository.GetAllProductsAsync();
            return _mapper.Map<List<WashMachineModel>>(resultProducts);
        }
    }
}