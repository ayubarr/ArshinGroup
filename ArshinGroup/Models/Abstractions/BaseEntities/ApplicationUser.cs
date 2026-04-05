using Microsoft.AspNetCore.Identity;

namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
