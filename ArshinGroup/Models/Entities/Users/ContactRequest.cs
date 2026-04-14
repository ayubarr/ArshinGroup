using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Users
{
    public class ContactRequest : BaseContactInfo
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

    }
}
