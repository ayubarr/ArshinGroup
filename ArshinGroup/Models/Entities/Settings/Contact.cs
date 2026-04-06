using ArshinGroup.Domain.Models.Abstractions.BaseEntities;
using ArshinGroup.Domain.Models.Enums;

namespace ArshinGroup.Domain.Models.Entities.Settings
{
    public class Contact : BaseContactInfo
    {
        public string OfficeNameEN { get; set; }
        public string OfficeNameRU { get; set; }
        public string AddressEN { get; set; }
        public string AddressRU { get; set; }
        public string WorkingHoursRU { get; set; }
        public int MapLAT { get; set; }
        public int MapLNG { get; set; }

        public SortOrder SortOrder { get; set; }
        public bool isActive { get; set; }
    }
}
