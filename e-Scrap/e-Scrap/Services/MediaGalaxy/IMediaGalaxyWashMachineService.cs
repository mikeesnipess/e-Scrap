using e_crap.Models.Common.WashMachine;

namespace eScrap.Services.MediaGalaxy
{
    public interface IMediaGalaxyWashMachineService
    {
        Task<List<WashMachineModel>> GetMediaGalaxyWashMachine();
    }
}
