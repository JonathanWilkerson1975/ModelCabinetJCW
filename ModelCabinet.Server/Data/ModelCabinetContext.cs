using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Data
{
    public class ModelCabinetContext : DbContext
    {
        public ModelCabinetContext (DbContextOptions<ModelCabinetContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 1,
                    Name = "Test Project"
                }
            );

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    AssetId = 1,
                    Name = "Test Asset"
                },
                new Asset
                {
                    AssetId = 2,
                    Name = "Test Benchy"
                }
            );

        }

        public DbSet<ModelCabinet.Server.Models.Project> Project { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Asset> Asset { get; set; } = default!;
    }
}
