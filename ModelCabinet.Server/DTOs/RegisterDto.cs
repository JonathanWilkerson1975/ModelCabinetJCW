using System.ComponentModel.DataAnnotations;

namespace ModelCabinet.Server.DTOs
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(1000)]
        public string? Biography { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(200)]
        [Url]
        public string? Website { get; set; }

        [StringLength(200)]
        [Url]
        public string? AvatarUrl { get; set; }

        [StringLength(50)]
        public string? TwitterHandle { get; set; }

        [StringLength(50)]
        public string? GithubUsername { get; set; }

        [StringLength(50)]
        public string? PreferredLanguage { get; set; }

        [StringLength(50)]
        public string? TimeZone { get; set; }
    }
}
