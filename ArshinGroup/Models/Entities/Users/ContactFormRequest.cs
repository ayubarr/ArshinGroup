using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Users
{
    public class ContactFormRequest : BaseContactInfo
    {
        public string Name { get; set; }
        public string Message { get; set; }

    }
}
