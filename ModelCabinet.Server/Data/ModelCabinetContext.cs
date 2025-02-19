using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Data
{
    public class ModelCabinetContext : IdentityDbContext<ApplicationUser>
    {
        public ModelCabinetContext(DbContextOptions<ModelCabinetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DateTime dateTime = new DateTime(2024, 01, 01);
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 1,
                    Name = "Test Project",
                    CreationDate = dateTime,
                    ModifiedDate = dateTime,
                    Description = "Description",
                    Author = "Author",
                    Version = "0.0.1",
                    ShortDescription = "Desc",
                    Slug = "nomen-est-omen",
                },
                new Project
                {
                    ProjectId = 2,
                    Name = "Test Project Two",
                    CreationDate = dateTime,
                    ModifiedDate = dateTime,
                    Description = "Description",
                    Author = "Author",
                    Version = "0.0.1",
                    ShortDescription = "Desc",
                    Slug = "nomen-est-bonum",
                }
            );

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    AssetId = 1,
                    Name = "Test Asset",
                    Path = Path.Combine("Assets", "TestProject", "HelloWorld.stl"),
                    DateCreation = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    FileSize = 446684,
                    ProjectId = 1
                },
                new Asset
                {
                    AssetId = 2,
                    Name = "Benchy",
                    Path = Path.Combine("Assets", "TestProject", "3DBenchy.stl"),
                    DateCreation = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    FileSize = 11285384,
                    ProjectId = 1
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    TagName = "Stress Test",
                    Color = "fae033"
                },
                new Tag
                {
                    TagId = 2,
                    TagName = "D&D",
                    Color = "df0000"
                },
                new Tag
                {
                    TagId = 3,
                    TagName = "Pathfinder",
                    Color = "40E0D0"
                },
                new Tag
                {
                    TagId = 4,
                    TagName = "Low Detail",
                    Color = "afafaf"
                },
                new Tag
                {
                    TagId = 5,
                    TagName = "High Detail",
                    Color = "3f3f3f"
                },
                new Tag
                {
                    TagId = 6,
                    TagName = "Video Game",
                    Color = "23a300"
                }
            );

            modelBuilder.Entity<AssetTag>().HasData(
                new AssetTag
                {
                    AssetId = 2,
                    TagId = 1
                },
                new AssetTag
                {
                    AssetId = 1,
                    TagId = 6
                }
            );

            modelBuilder.Entity<ProjectTag>().HasData(
                new ProjectTag
                {
                    TagId = 3,
                    ProjectId = 1
                },
                new ProjectTag
                {
                    TagId = 4,
                    ProjectId = 1
                },
                new ProjectTag
                {
                    TagId = 5,
                    ProjectId = 1
                },
                new ProjectTag
                {
                    TagId = 1,
                    ProjectId = 2
                },
                new ProjectTag
                {
                    TagId = 2,
                    ProjectId = 2
                },
                new ProjectTag
                {
                    TagId = 5,
                    ProjectId = 2
                }
            );

            // auto load any navigation properties using this pattern
            modelBuilder.Entity<Project>().Navigation(p => p.Assets).AutoInclude();

            // Ensures each slug is unique
            modelBuilder.Entity<Project>().HasIndex(p => p.Slug).IsUnique();

            modelBuilder.Entity<Tag>().HasIndex(t => t.TagName).IsUnique();

            modelBuilder.Entity<AssetTag>()
                .HasOne(at => at.Asset)
                .WithMany(a => a.Tags)
                .HasForeignKey(t => t.AssetId);

            modelBuilder.Entity<AssetTag>()
                .HasOne(at => at.Tag)
                .WithMany(a => a.AssetTags)
                .HasForeignKey(t => t.TagId);

            modelBuilder.Entity<ProjectTag>()
                .HasOne(at => at.Project)
                .WithMany(a => a.Tags)
                .HasForeignKey(t => t.ProjectId);

            modelBuilder.Entity<ProjectTag>()
                .HasOne(at => at.Tag)
                .WithMany(a => a.ProjectTags)
                .HasForeignKey(t => t.TagId);
        }

        public DbSet<ModelCabinet.Server.Models.Project> Project { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Asset> Asset { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Tag> Tag { get; set; } = default!;
    }
}
