using System;
using System.ComponentModel.DataAnnotations;

namespace RickardIpsum.DAL.Models
{
    public abstract class DbModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public bool Deleted { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset LastModified { get; set; }        
    }
}