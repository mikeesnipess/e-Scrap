using AutoMapper;
using eScrap.Models.Common.Laptop;
using eScrap.Repository;
namespace eScrap.Services.Altex.Laptop
{
    public class AltexLaptopService : IAltexLaptopService
    {
        private readonly IAltexLaptopRepository _altexLaptopRepository;
        private readonly IMapper _mapper;
        public AltexLaptopService(IAltexLaptopRepository altexLaptopRepository,IMapper mapper)
        {
            _altexLaptopRepository = altexLaptopRepository;
            _mapper = mapper;
        }
        public async Task<List<LaptopModel>> GetLaptopListAsync()
        {
            var laptops = await _altexLaptopRepository.GetAllProductsAsync();
            return _mapper.Map<List<LaptopModel>>(laptops);
        }
    }
}
