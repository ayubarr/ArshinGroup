using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Settings
{
    public class NewsItem : BaseContentInfo
    {
        public string ExcprtpRU {  get; set; }
        public string ExcprtpEN { get; set; }
        public string ExcprtpZH { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
