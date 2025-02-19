using Microsoft.AspNetCore.Identity;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Data
{
    public static class ModelCabinetContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<(ApplicationUser User, string Password)>
                {
                    (new ApplicationUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        DisplayName = "Admin User",
                        Biography = "System administrator",
                        Location = "Server Room",
                        EmailConfirmed = true
                    }, "Admin123!"),

                    (new ApplicationUser
                    {
                        UserName = "testuser@example.com",
                        Email = "testuser@example.com",
                        DisplayName = "Test User",
                        Biography = "Product designer and 3D printing enthusiast",
                        Location = "New York",
                        EmailConfirmed = true
                    }, "Test123!"),

                    (new ApplicationUser
                    {
                        UserName = "toastuser@example.com",
                        Email = "toastuser@example.com",
                        DisplayName = "Toast User",
                        Biography = "Mechanical engineer and CAD expert",
                        Location = "San Francisco",
                        EmailConfirmed = true
                    }, "Toast123!")
                };

                foreach (var (user, password) in users)
                {
                    var result = await userManager.CreateAsync(user, password);
                    if (!result.Succeeded)
                    {
                        throw new Exception($"Failed to seed user {user.Email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                    }
                }
            }
        }
    }
}
