using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModelCabinet.Server.Data;


namespace ModelCabinet.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ModelCabinetContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ModelCabinetContext")
                    ?? throw new InvalidOperationException("Connection string 'ModelCabinetContext' not found.")));


            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();


            app.UseDefaultFiles();
            app.UseStaticFiles();


            if (app.Environment.IsDevelopment())
            {
#if DEBUG
                Console.WriteLine("Running in DEBUG mode - Switching to 'development' branch.");
                SwitchToCorrectBranch("development");
#else
                    Console.WriteLine("Running in RELEASE mode - Ensuring 'master' branch is used.");
                    SwitchToCorrectBranch("master");
#endif
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {


            }


            // Configure the HTTP request pipeline.


            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.MapFallbackToFile("/index.html");


            app.Run();
        }


        private static void SwitchToCorrectBranch(string branchName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = $"switch {branchName}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();


                    Console.WriteLine($"Git Output: {output}");
                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.WriteLine($"Git Error: {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error switching to {branchName} branch: {ex.Message}");
            }
        }
    }
}




