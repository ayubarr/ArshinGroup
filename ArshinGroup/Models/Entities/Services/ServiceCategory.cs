using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Services
{
    public class ServiceCategory : BaseTitleInfo
    {
        public string Slug { get; set; }

        public ICollection<ServiceEntity>? Services { get; set; }
    }
}
