﻿using Models.Common.Refrigerator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Altex.Refrigerator
{
    public interface IAltexRefrigeratorService
    {
        Task<List<RefrigeratorModel>> GetAltexRefrigerator();
    }
}
