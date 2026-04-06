using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Solutions
{
    public class SolutionFeature : BaseFeatures
    {
        public int? SolutionId { get; set; }
        public Solution? Solution { get; set; }
    }
}
