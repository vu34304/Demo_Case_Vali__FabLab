﻿using DemoCaseGui.Core.Application.Models;
using DemoCaseGui.Core.Application.Persistence.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCaseGui.Core.Application.Repositories
{
    public interface IInverterLogRepository
    {
        Task<IEnumerable<InverterLog>> GetListAsync(TimeRangeQuery query, string name);
    }
}
