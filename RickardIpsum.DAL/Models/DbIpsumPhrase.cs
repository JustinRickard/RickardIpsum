using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickardIpsum.DAL.Models
{
    public class DbIpsumPhrase : DbModelBase
    {
        [ForeignKey("IpsumId")]
        public Guid IpsumId { get; set; }
        public DbIpsum Ipsum { get; set; }

        [MaxLength(50)]
        public string Phrase { get; set; }

        public DateTimeOffset ApprovedTime { get; set; }

        [ForeignKey("ApprovedByUserId")]
        public Guid ApprovedByUserId { get; set; }
        public DbUser ApprovedByUser { get; set; }
    }
}