using Contoso.SurfaceTemperatureGuard.API.Data.EfCore;
using Contoso.SurfaceTemperatureGuard.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Validation;

namespace Contoso.SurfaceTemperatureGuard.API.Controllers
{
    [Authorize(AuthenticationSchemes = OpenIddictValidationDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : DBControllerBase<Device, EfCoreDeviceRepository>
    {
        public DeviceController(EfCoreDeviceRepository DeviceRepository) : base(DeviceRepository)
        {

        }
    }
}