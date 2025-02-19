namespace ModelCabinet.Server.DTOs
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string? Biography { get; set; }
        public string? Location { get; set; }
        public string? Website { get; set; }
        public string? AvatarUrl { get; set; }
        public string? TwitterHandle { get; set; }
        public string? GithubUsername { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? TimeZone { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime LastActive { get; set; }
        public bool IsProfilePublic { get; set; }
        public bool EmailNotificationsEnabled { get; set; }
        public bool ProjectUpdatesEnabled { get; set; }
        public bool NewMessageNotificationsEnabled { get; set; }
    }
}
