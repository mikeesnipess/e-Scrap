using AutoMapper;
using e_Scrap.Models.Common.GasCooker;
using eScrap.Repository;
using Models.Common.Refrigerator;
using Services.eMag.Refrigerator;

public class eMagRefrigeratorService : IEmagRefrigeratorService
{
    private readonly IEMagRefrigeratorRepository _eMagRefrigeratorRepository;
    private readonly IMapper _mapper;

    public eMagRefrigeratorService(IEMagRefrigeratorRepository eMagRefrigeratorRepository, IMapper mapper)
    {
        _eMagRefrigeratorRepository = eMagRefrigeratorRepository;
        _mapper = mapper;
    }

    public async Task<List<RefrigeratorModel>> GetRefrigeratorProducts()
    {
        var resultProducts = await _eMagRefrigeratorRepository.GetAllProductsAsync();
        return _mapper.Map<List<RefrigeratorModel>>(resultProducts);
    }
}
