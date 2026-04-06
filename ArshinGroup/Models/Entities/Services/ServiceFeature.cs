using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Services
{
    public class ServiceFeature : BaseFeatures
    {
        public int? ServiceId { get; set; }
        public ServiceEntity? ServiceEntity { get; set; }
    }
}
