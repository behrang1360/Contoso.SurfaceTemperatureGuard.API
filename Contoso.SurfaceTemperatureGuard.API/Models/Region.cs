using Contoso.SurfaceTemperatureGuard.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.SurfaceTemperatureGuard.API.Models
{
    public class Region: IEntity
    {        
        public int Id { get; set; }
        public string Name { get; set; }     
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
