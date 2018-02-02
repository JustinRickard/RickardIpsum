using System.ComponentModel.DataAnnotations;

namespace RickardIpsum.DAL.Models
{
    public class DbUser : DbModelBase
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}