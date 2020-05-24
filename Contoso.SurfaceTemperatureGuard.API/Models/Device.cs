using Contoso.SurfaceTemperatureGuard.API.Data;
using System.Collections.Generic;

namespace Contoso.SurfaceTemperatureGuard.API.Models
{
    public class Device : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DeviceTemperatureLog> DeviceTemperatureLogs { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
