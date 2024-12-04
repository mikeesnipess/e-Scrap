using Models.Common.Refrigerator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e.Services.Altex
{
    public interface IAltexRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetAltexRefrigerator();
    }
}
