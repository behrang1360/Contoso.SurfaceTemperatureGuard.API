using Contoso.SurfaceTemperatureGuard.API.Data.EfCore;
using Contoso.SurfaceTemperatureGuard.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.SurfaceTemperatureGuard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : DBControllerBase<Region, EfCoreRegionRepository>
    {
        public RegionController(EfCoreRegionRepository regionRepository) : base(regionRepository)
        {

        }
    }
}