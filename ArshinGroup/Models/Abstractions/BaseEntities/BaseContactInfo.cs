namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class BaseContactInfo : BaseEntity
    {
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
