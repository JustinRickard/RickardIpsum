using System;
using System.Collections.Generic;
using System.Linq;
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

        public void SetInitialValues(DbModelBase model) {
            var now = DateTime.Now;
            model.DateCreated = now;
            model.LastModified = now;
            model.Deleted = false;
             
        }

        public void Save() {
            this.SaveChanges();
        }

        // Generic GET
        public IQueryable<TEntity> GetNotDeleted<TEntity>() where TEntity : DbModelBase {            
            return Set<TEntity>()
                .Where(x => !x.Deleted);
            }

        public IQueryable<TEntity> GetDeleted<TEntity>() where TEntity : DbModelBase {
            
            return Set<TEntity>()
                .Where(x => x.Deleted);
        }

        public TEntity GetById<TEntity>(Guid id) where TEntity : DbModelBase {
            return Set<TEntity>()
                .FirstOrDefault(x => x.Id == id);
        }

        // Generic CREATE
        public void Create<TEntity>(TEntity record) where TEntity : DbModelBase {
            SetInitialValues(record);
            Set<TEntity>().Add(record);
            Save();
        }

        // Generic UPDATE
        public void UpdateRecord<TEntity>(TEntity record) where TEntity : DbModelBase {
            Set<TEntity>().Update(record);
            Save();
        }

        // Generic DELETE
        public void Delete<TEntity>(TEntity record) where TEntity : DbModelBase {
            var ipsum = GetById<DbIpsum>(record.Id);
            if (ipsum != null) {
                ipsum.Deleted = true;
            }
            Save();
        }
    }
}
