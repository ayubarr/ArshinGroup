using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Solutions
{
    public class SolutionProduct : BaseEntity
    {
        public string Language { get; set; }
        public string Name { get; set; }
        public string ChinaPrice { get; set; }
        public string SortOrder { get; set; }

        public int? SolutionId { get; set; }
        public Solution? Solution { get; set; }
    }
}
