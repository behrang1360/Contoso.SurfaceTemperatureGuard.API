using Contoso.SurfaceTemperatureGuard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.SurfaceTemperatureGuard.API.Data.EfCore
{
    public class EfCoreDeviceTemperatureLogRepository : EfCoreRepository<DeviceTemperatureLog, ApplicationDbContext>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EfCoreDeviceTemperatureLogRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
    }
}
