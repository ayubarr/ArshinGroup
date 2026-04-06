using ArshinGroup.Domain.Models.Enums;

namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class BaseFeatures : BaseEntity
    {
        public LanguegeType Languege { get; set; }
        public string Value { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}
