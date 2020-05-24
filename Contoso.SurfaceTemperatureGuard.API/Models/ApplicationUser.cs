using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.SurfaceTemperatureGuard.API.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<Region> Regions { get; set; }        
    }
}
