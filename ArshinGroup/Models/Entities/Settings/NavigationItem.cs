using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Settings
{
    public class NavigationItem : BaseTitleInfo
    {
        public string Url { get; set; }
        public int? Level { get; set; }

        public int? MenuId { get; set; }
        public NavigationMenu? NavigationMenu { get; set; }

        public int? ParrentId { get; set; }
        public NavigationItem? Parent {  get; set; }

        public ICollection<NavigationItem>? Children { get; set; } = new List<NavigationItem>();
    }
}
