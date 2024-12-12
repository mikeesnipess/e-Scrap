using e_crap.Models.Common.WashMachine;

namespace Services.eMag.WashMachine
{
    public interface IEmagWashMachineService
    {
        Task<List<WashMachineModel>> GetWashMachineEMag();
    }
}
