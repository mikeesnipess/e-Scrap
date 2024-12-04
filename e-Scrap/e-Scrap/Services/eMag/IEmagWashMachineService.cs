using e_crap.Models.Common.WashMachine;

namespace eScrap.Services.eMag
{
    public interface IEmagWashMachineService
    {
        Task<List<WashMachineModel>> GetWashMachineEMag();
    }
}
