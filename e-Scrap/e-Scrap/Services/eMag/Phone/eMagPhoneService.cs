using AutoMapper;
using e_Scrap.Models.Common.GasCooker;
using e_Scrap.Models.Common.Phone;
using eScrap.Repository;

namespace eScrap.Services.eMag.Phone
{
    public class eMagPhoneService : IEmagPhoneService
    {
        private readonly IEMagPhonesRepository _eMagPhonesRepository;
        private readonly IMapper _mapper;

        public eMagPhoneService(IEMagPhonesRepository eMagPhonesRepository, IMapper mapper)
        {
            _eMagPhonesRepository = eMagPhonesRepository;
            _mapper = mapper;
        }

        public async Task<List<PhoneModel>> GetEmagPhones()
        {
            var resultProducts = await _eMagPhonesRepository.GetAllProductsAsync();
            return _mapper.Map<List<PhoneModel>>(resultProducts);
        }
    }
}
