using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Solutions
{
    public class Solution : BaseOrderInfo
    {
        public string Icon { get; set; }
        public string Color { get; set; }

        public ICollection<SolutionFeature>? Features { get; set; }
        public ICollection<SolutionProduct>? SolutionProducts { get; set; }

    }
}
