using Contoso.SurfaceTemperatureGuard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.SurfaceTemperatureGuard.API.Data.EfCore
{
    public class EfCoreRegionRepository : EfCoreRepository<Region, ApplicationDbContext>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EfCoreRegionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
    }
}
