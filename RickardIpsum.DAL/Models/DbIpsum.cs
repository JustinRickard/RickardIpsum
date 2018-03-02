using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickardIpsum.DAL.Models
{
    public class DbIpsum : DbModelBase
    {
        [MaxLength(50)]
        public string DisplayName { get; set; }
        [MaxLength(50)]
        public string AdminName { get; set; }
        [MaxLength(256)]
        public string ThumbnailUrl { get; set; }
        [MaxLength(256)]
        public string BackgroundUrl { get; set; }

        [ForeignKey("CreatedBy")]
        public Guid CreatedBy { get; set; }
        public DbUser CreatedByUser { get; set; }
    }
}