using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Settings
{
    public class Banner : BaseTitleInfo
    {
        public string SubTitleRU { get; set; }
        public string SubTitleEN { get; set; }
        public string SubTitleZH { get; set; }
        public string ButtonTextRU { get; set; }
        public string ButtonTextEN { get; set; }
        public string ButtonTextZH { get; set; }
        public string ImageUrl{ get; set; }
        public string ButtonUrl { get; set; }

    }
}
