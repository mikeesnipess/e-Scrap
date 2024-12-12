using e_crap.Models.Common.WashMachine;

namespace Services.MediaGalaxy.WashMachine
{
    public interface IMediaGalaxyWashMachineService
    {
        Task<List<WashMachineModel>> GetMediaGalaxyWashMachine();
    }
}
