using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Users
{
    public class User : ApplicationUser
    {
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
