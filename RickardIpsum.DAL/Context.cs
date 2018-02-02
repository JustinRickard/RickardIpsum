using System;
using Microsoft.EntityFrameworkCore;
using RickardIpsum.DAL.Models;

namespace RickardIpsum.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { 
            // Tracking is not required for disconnected web apps.
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        }

        public DbSet<DbIpsum> Ipsums { get; set; }
        public DbSet<DbIpsumPhrase> Phrases { get; set; }
        public DbSet<DbUser> Users { get; set; }
    }
}
