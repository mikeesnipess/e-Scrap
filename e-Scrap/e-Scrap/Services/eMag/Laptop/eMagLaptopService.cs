using AutoMapper;
using eScrap.Models.Common.Laptop;
using eScrap.Repository;

namespace eScrap.Services.eMag.Laptop
{
    public class eMagLaptopService : IEmagLaptopService
    {
        private readonly IEMagLaptopRepository _eMagLaptopRepository;
        private readonly IMapper _mapper;

        public eMagLaptopService(IEMagLaptopRepository eMagLaptopRepository, IMapper mapper)
        {
            _eMagLaptopRepository = eMagLaptopRepository;
            _mapper = mapper;
        }

        public async Task<List<LaptopModel>> GetEmagLaptop()
        {
            var resultProducts = await _eMagLaptopRepository.GetAllProductsAsync();
            return _mapper.Map<List<LaptopModel>>(resultProducts);
        }
    }
}
