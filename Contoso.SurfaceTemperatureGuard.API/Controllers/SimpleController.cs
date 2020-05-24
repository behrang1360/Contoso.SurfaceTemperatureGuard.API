using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Contoso.SurfaceTemperatureGuard.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Validation;

namespace Contoso.SurfaceTemperatureGuard.API.Controllers
{
    [Authorize(AuthenticationSchemes = OpenIddictValidationDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]    
    public class SimpleController : ControllerBase
    {
        public UserManager<ApplicationUser> _UserManager { get; }

        public SimpleController(UserManager<ApplicationUser> userManager)
        {
            _UserManager = userManager;
        }

        
        [HttpGet]
        public List<string> Get()
        {
            return new List<string>
            {
                "This",
                "is",
                "a",
                "test"
            };
        }
    }
}