using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
       

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgrammingLanguage>(a =>
            {
                a.ToTable("ProgrammingLanguages").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Version).HasColumnName("Version");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.UpdatedTime).HasColumnName("UpdatedTime");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");

                a.HasMany(p => p.PLTechnologies);
            });

            modelBuilder.Entity<PLTechnology>(a =>
            {
                a.ToTable("PLTechnologies").HasKey(p => p.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.ProgrammingLanguageId).HasColumnName("ProgrammingLanguageId");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.ReleaseTime).HasColumnName("ReleaseTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.UpdatedTime).HasColumnName("UpdatedTime");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");

                a.HasOne(p => p.ProgrammingLanguage);
            });

            ProgrammingLanguage[] programmingLanguageEntitySeeds = { new(1, "C", "7.0", DateTime.Now), new(2, "Ruby", "4.0" ,DateTime.Now) };
            modelBuilder.Entity<ProgrammingLanguage>().HasData(programmingLanguageEntitySeeds);

            PLTechnology[] pLTechnologyEntitySeeds = { new (1, 1, "Deneme C", Convert.ToDateTime("01/10/1978"), DateTime.Now), new(2, 4, "Deneme Jaava", Convert.ToDateTime("01/10/1998"), DateTime.Now),
                                                       new (3, 5, "Deneme C++", Convert.ToDateTime("21/10/2002"), DateTime.Now)};
            modelBuilder.Entity<PLTechnology>().HasData(pLTechnologyEntitySeeds);

        }
    }
}
