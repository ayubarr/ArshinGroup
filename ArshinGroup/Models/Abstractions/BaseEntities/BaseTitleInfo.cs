using ArshinGroup.Domain.Models.Enums;

namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class BaseTitleInfo : BaseEntity
    {
        public string TitleRU { get; set; }
        public string TitleZH { get; set; }
        public string TitleEN { get; set; }
        public SortOrder SortOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
