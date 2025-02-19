using Microsoft.AspNetCore.Identity;

namespace ModelCabinet.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public string? Biography { get; set; }
        public string? Location { get; set; }
        public string? Website { get; set; }
        public string? AvatarUrl { get; set; }
        public string? TwitterHandle { get; set; }
        public string? GithubUsername { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? TimeZone { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public bool IsProfilePublic { get; set; } = true;
        public bool EmailNotificationsEnabled { get; set; } = true;
        public bool ProjectUpdatesEnabled { get; set; } = true;
        public bool NewMessageNotificationsEnabled { get; set; } = true;

    }
}
