using System;

namespace RickardIpsum.Api.ViewModels
{
    public class IpsumPostModel
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public Guid CreatedByUserId { get; set; }
    }
}