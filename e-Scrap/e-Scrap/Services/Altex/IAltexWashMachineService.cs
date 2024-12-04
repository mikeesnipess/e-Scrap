using e_crap.Models.Common.WashMachine;

namespace eScrap.Services.Altex
{
    public interface IAltexWashMachineService
    {
        Task<List<WashMachineModel>> GetAltexWashMachine();
    }
}
