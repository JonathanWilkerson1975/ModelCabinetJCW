using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Data
{
    public class ModelCabinetContext : DbContext
    {
        public ModelCabinetContext(DbContextOptions<ModelCabinetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // value can be anything
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
                    Path = Path.Combine(AppContext.BaseDirectory, "Assets", "TestProject", "HelloWorld.stl"),
                    DateCreation = dateTime,
                    DateUpdated = dateTime,
                    FileSize = 446684,
                    ProjectId = 1
                },
                new Asset
                {
                    AssetId = 2,
                    Name = "Benchy",
                    Path = Path.Combine(AppContext.BaseDirectory, "Assets", "TestProject", "3DBenchy.stl"),
                    DateCreation = dateTime,
                    DateUpdated = dateTime,
                    FileSize = 11285384,
                    ProjectId = 1
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    TagName = "Stress Test"
                },
                new Tag
                {
                    TagId = 2,
                    TagName = "D&D"
                },
                new Tag
                {
                    TagId = 3,
                    TagName = "Pathfinder"
                },
                new Tag
                {
                    TagId = 4,
                    TagName = "Low Detail"
                },
                new Tag
                {
                    TagId = 5,
                    TagName = "High Detail"
                },
                new Tag
                {
                    TagId = 6,
                    TagName = "Video Game"
                }
            );

            //modelBuilder.Entity<AssetTag>().HasData(
            //    new AssetTag
            //    {
            //        AssetId = 2,
            //        TagId = 1
            //    },
            //    new AssetTag
            //    {
            //        AssetId = 1,
            //        TagId = 6
            //    }
            //);

            //modelBuilder.Entity<ProjectTag>().HasData(
            //    new ProjectTag
            //    {
            //        TagId = 3,
            //        ProjectId = 1
            //    },
            //    new ProjectTag
            //    {
            //        TagId = 4,
            //        ProjectId = 1
            //    },
            //    new ProjectTag
            //    {
            //        TagId = 5,
            //        ProjectId = 1
            //    },
            //    new ProjectTag
            //    {
            //        TagId = 1,
            //        ProjectId = 2
            //    },
            //    new ProjectTag
            //    {
            //        TagId = 2,
            //        ProjectId = 2
            //    },
            //    new ProjectTag
            //    {
            //        TagId = 5,
            //        ProjectId = 2
            //    }
            //);

            // auto load any navigation properties using this pattern
            modelBuilder.Entity<Project>().Navigation(p => p.Assets).AutoInclude();


            modelBuilder.Entity<Tag>().HasIndex(t => t.TagName).IsUnique();
            //modelBuilder.Entity<Tag>().Navigation(t => t.Assets).AutoInclude();
            //modelBuilder.Entity<Tag>().Navigation(t => t.Projects).AutoInclude();

            // This Does Link the Tags, but it doesn't pull them automatically.
            // Changing it to a Navigation with an auto include gives me an "Cant Create A Context" error.


            //modelBuilder.Entity<AssetTag>()
            //    .HasOne<Asset>(a => a.Asset)
            //    .WithMany(at => at.AssetTags)
            //    .HasForeignKey(at => at.AssetId);
            //modelBuilder.Entity<AssetTag>()
            //    .HasOne<Tag>(t => t.Tag)
            //    .WithMany(t => t.AssetTags)
            //    .HasForeignKey(at => at.TagId);

            //modelBuilder.Entity<ProjectTag>()
            //    .HasOne<Project>(pt => pt.Project)
            //    .WithMany(pt => pt.ProjectTags)
            //    .HasForeignKey(pt => pt.ProjectId);
            //modelBuilder.Entity<ProjectTag>()
            //    .HasOne<Tag>(t => t.Tag)
            //    .WithMany(t => t.ProjectTags)
            //    .HasForeignKey(pt => pt.TagId);
        }

        public DbSet<ModelCabinet.Server.Models.Project> Project { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Asset> Asset { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Tag> Tag { get; set; } = default!;
    }
}
