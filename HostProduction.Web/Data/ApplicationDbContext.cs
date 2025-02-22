﻿using HostProduction.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HostProduction.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<ProductionFacility>()
                .HasIndex(p => p.Code)
                .IsUnique();

            builder.Entity<ProcessEquipmentType>()
                .HasIndex(p => p.Code)
                .IsUnique();

            builder.ApplyConfiguration(new ProductionFacilitySeedConfiguration());
            builder.ApplyConfiguration(new ProcessEquipmentTypeSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

			base.OnModelCreating(builder);
		}

		public DbSet<ProductionFacility> ProductionFacilities { get; set; }
        public DbSet<ProcessEquipmentType> ProcessEquipmentTypes { get; set; }
        public DbSet<EquipmentPlacementContract> EquipmentPlacementContracts { get; set; }
    }
}
