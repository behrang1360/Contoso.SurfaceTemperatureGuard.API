using Contoso.SurfaceTemperatureGuard.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.SurfaceTemperatureGuard.API.Models
{
    public class DeviceTemperatureLog : IEntity
    {
        public int Id { get; set; }
        public DateTime LogDateTime { get; set; }
        public float Temperature { get; set; }
        public Device Device { get; set; }
        public int DeviceId { get; set; }
    }


}
