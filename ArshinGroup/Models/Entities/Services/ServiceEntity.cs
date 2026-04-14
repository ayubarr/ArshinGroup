using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Services
{
    public class ServiceEntity : BaseOrderInfo
    {
        public string Icon { get; set; }

        public ICollection<ServiceFeature>? ServiceFeatures { get; set; }
        public int? ServiceCategoryId { get; set; }
        public ServiceCategory? ServiceCategory { get; set; }
    }
}
