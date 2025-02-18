using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModelCabinet.Server.DTOs;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<AuthController> _logger;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                DisplayName = model.DisplayName,
                Biography = model.Biography,
                Location = model.Location,
                Website = model.Website,
                AvatarUrl = model.AvatarUrl,
                TwitterHandle = model.TwitterHandle,
                GithubUsername = model.GithubUsername,
                PreferredLanguage = model.PreferredLanguage,
                TimeZone = model.TimeZone,
                DateJoined = DateTime.UtcNow,
                LastActive = DateTime.UtcNow,
                IsProfilePublic = true,
                EmailNotificationsEnabled = true,
                ProjectUpdatesEnabled = true,
                NewMessageNotificationsEnabled = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");

                await _signInManager.SignInAsync(user, isPersistent: false);

                return Ok(MapToUserDto(user));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(
                model.Email,
                model.Password,
                model.RememberMe,
                lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                // Update LastActive
                user.LastActive = DateTime.UtcNow;
                await _userManager.UpdateAsync(user);

                _logger.LogInformation("User logged in.");

                return Ok(MapToUserDto(user));
            }

            if (result.RequiresTwoFactor)
            {
                return BadRequest(new { message = "Two factor authentication required" });
            }

            if (result.IsLockedOut)
            {
                _logger.LogWarning("User account locked out.");
                return BadRequest(new { message = "User account locked out" });
            }

            return BadRequest(new { message = "Invalid login attempt" });
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return Ok(new { message = "Logged out successfully" });
        }

        [HttpGet("current")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
                return Unauthorized();

            // Update LastActive
            user.LastActive = DateTime.UtcNow;
            await _userManager.UpdateAsync(user);

            return Ok(MapToUserDto(user));
        }

        private static UserDto MapToUserDto(ApplicationUser user)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                DisplayName = user.DisplayName,
                Biography = user.Biography,
                Location = user.Location,
                Website = user.Website,
                AvatarUrl = user.AvatarUrl,
                TwitterHandle = user.TwitterHandle,
                GithubUsername = user.GithubUsername,
                PreferredLanguage = user.PreferredLanguage,
                TimeZone = user.TimeZone,
                DateJoined = user.DateJoined,
                LastActive = user.LastActive,
                IsProfilePublic = user.IsProfilePublic,
                EmailNotificationsEnabled = user.EmailNotificationsEnabled,
                ProjectUpdatesEnabled = user.ProjectUpdatesEnabled,
                NewMessageNotificationsEnabled = user.NewMessageNotificationsEnabled
            };
        }
    }
}
