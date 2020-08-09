﻿using System.Collections.Generic;
using GNB.Services.Dtos;

namespace GNB.Services
{
    public interface IRateResolver
    {
        Dictionary<(string, string), decimal> GetRates(List<(string from, string to)> missingRates,
            List<RateDto> availableRates);
    }
}
