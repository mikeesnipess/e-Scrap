using AutoMapper;
using e_Scrap.Models.Common.GasCooker;
using eScrap.Repository;
using Services.eMag.GasCoooker;

public class eMagGasCookerService : IEmagGasCookerService
{
    private readonly IEMagGasCookerRepository _eMagGasCookerRepository;
    private readonly IEMagGasCookerEmbeddedRepository _eMagGasCookerEmbeddedRepository;
    private readonly IEMagOvenEmbeddedRepository _eMagOvenEmbeddedRepository;
    private readonly IEMagHoodRepository _eMagHoodRepository;
    private readonly IMapper _mapper;

    public eMagGasCookerService(IEMagGasCookerRepository eMagGasCookerRepository, IEMagGasCookerEmbeddedRepository eMagGasCookerEmbeddedRepository,
        IEMagOvenEmbeddedRepository eMagOvenEmbeddedRepository, IEMagHoodRepository eMagHoodRepository, IMapper mapper)
    {
        _eMagGasCookerRepository = eMagGasCookerRepository;
        _eMagGasCookerEmbeddedRepository = eMagGasCookerEmbeddedRepository;
        _eMagOvenEmbeddedRepository = eMagOvenEmbeddedRepository;
        _eMagHoodRepository = eMagHoodRepository;
        _mapper = mapper;
    }

    public async Task<List<GasCookerModel>> GetGasCookerEmbeddedProducts()
    {
        var resultProducts = await _eMagGasCookerEmbeddedRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }
    public async Task<List<GasCookerModel>> GetGasCookerProducts()
    {
        var resultProducts = await _eMagGasCookerRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }

    public async Task<List<GasCookerModel>> GetHoodProducts()
    {
        var resultProducts = await _eMagHoodRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }
    public async Task<List<GasCookerModel>> GetOvenEmbeddedProducts()
    {
        var resultProducts = await _eMagOvenEmbeddedRepository.GetAllProductsAsync();
        return _mapper.Map<List<GasCookerModel>>(resultProducts);
    }
}
