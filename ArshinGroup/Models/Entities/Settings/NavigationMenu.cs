using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Settings
{
    public class NavigationMenu : BaseTitleInfo
    {
        public string Slug { get; set; }

        public ICollection<NavigationItem>? Items { get; set; }
    }
}
