using AutoMapper;
using e_Scrap.Models.Common.GasCooker;
using eScrap.Repository;
using Services.Altex.GasCooker;

public class AltexGasCookerService : IAltexGasCookerService
{
    private readonly IAltexGasCookerRepository _altexGasCookerRepository;
    private readonly IAltexGasCookerEmbeddedRepository _altexGasCookerEmbeddedRepository;
    private readonly IAltexOvenEmbeddedRepository _altexOvenEmbeddedRepository;
    private readonly IAltexOvenEmbeddedRepository _altexHoodRepository;
    private readonly IMapper _mapper;

    public AltexGasCookerService(IAltexGasCookerRepository altexGasCookerRepository, IMapper mapper, IAltexGasCookerEmbeddedRepository altexGasCookerEmbeddedRepository, IAltexOvenEmbeddedRepository altexOvenEmbeddedRepository, IAltexOvenEmbeddedRepository altexHoodRepository)
    {
        _altexGasCookerRepository = altexGasCookerRepository;
        _altexGasCookerEmbeddedRepository = altexGasCookerEmbeddedRepository;
        _altexOvenEmbeddedRepository = altexOvenEmbeddedRepository;
        _altexHoodRepository = altexHoodRepository;
        _mapper = mapper;
    }

    public async Task<List<GasCookerModel>> GetGasCookerAltex()
    {
        var resultProducts = await _altexGasCookerRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }

    public async Task<List<GasCookerModel>> GetGasCookerEmbeddedAltex()
    {
        var resultProducts = await _altexGasCookerEmbeddedRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }

    public async Task<List<GasCookerModel>> GetOvenEmbeddedAltex()
    {
        var resultProducts = await _altexOvenEmbeddedRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }

    public async Task<List<GasCookerModel>> GetHoodAltex()
    {
        var resultProducts = await _altexHoodRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);

    }
}

