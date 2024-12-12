using e_crap.Models.Common.WashMachine;

namespace Services.Altex.WashMachine
{
    public interface IAltexWashMachineService
    {
        Task<List<WashMachineModel>> GetAltexWashMachine();
    }
}
