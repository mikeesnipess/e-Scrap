using AutoMapper;
using e_Scrap.Models.Common.Phone;
using eScrap.Repository;
using eScrap.Services.MediaGalaxy.Phone;

public class MediaGalaxyPhoneService : IMediaGalaxyPhoneService
{
    private readonly IMediaGalaxyPhonesRepository _mediaGalaxyPhoneRepository;
    private readonly IMapper _mapper;

    public MediaGalaxyPhoneService(IMediaGalaxyPhonesRepository mediaGalaxyPhoneRepository, IMapper mapper)
    {
        _mediaGalaxyPhoneRepository = mediaGalaxyPhoneRepository;
        _mapper = mapper;
    }

    public async Task<List<PhoneModel>> GetProductListAsync()
    {
        var resultProducts = await _mediaGalaxyPhoneRepository.GetAllProductsAsync();
        return _mapper.Map<List<PhoneModel>>(resultProducts);
    }
}

