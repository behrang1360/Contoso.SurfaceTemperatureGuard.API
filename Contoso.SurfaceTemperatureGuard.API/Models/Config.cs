using Contoso.SurfaceTemperatureGuard.API.Data;
using System.ComponentModel.DataAnnotations;

namespace Contoso.SurfaceTemperatureGuard.API.Models
{
    public class Config : IEntity
    {

        public int Id { get; set; }
        [Required]
        public double Max { get; set; }
        [Required]
        public double Min { get; set; }
        [Required]
        public int RegionId { get; set; }

        public Region Region { get; set; }
    }
}
