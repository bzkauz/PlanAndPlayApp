﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanAndPlayApp.Services
{
    public interface IWebData
    {
        Task<Earthquake[]> GetEarthquakesAsync();

        Task<Object> GetPlanAndPlayt();
    }
}
