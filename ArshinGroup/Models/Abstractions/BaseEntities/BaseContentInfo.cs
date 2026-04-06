namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class BaseContentInfo : BaseTitleInfo
    {
        public string ContentRU { get; set; }
        public string ContentEN { get; set; }
        public string ContentZH { get; set; }
        public string Slug { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; }
    }
}
