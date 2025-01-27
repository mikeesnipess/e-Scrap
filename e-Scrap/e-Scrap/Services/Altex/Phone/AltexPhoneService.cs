using AutoMapper;
using e_Scrap.Models.Common.Phone;
using eScrap.Repository;
using Services.Altex.Phone;

public class AltexPhoneService : IAltexPhoneService
{
    private readonly IAltexPhonesRepository _phonesRepository;
    private readonly IMapper _mapper;

    public AltexPhoneService(IAltexPhonesRepository phonesRepository, IMapper mapper)
    {
        _phonesRepository = phonesRepository;
        _mapper = mapper;
    }

    public async Task<List<PhoneModel>> GetPhoneListAsync()
    {
        var resultProducts = await _phonesRepository.GetAllProductsAsync();
        return _mapper.Map<List<PhoneModel>>(resultProducts);
    }
}

