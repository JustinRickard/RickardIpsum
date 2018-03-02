using AutoMapper;
using RickardIpsum.Api.ViewModels;
using RickardIpsum.DAL.Models;

namespace RickardIpsum.Api
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() {
            CreateMap<IpsumPostModel, DbIpsum>().ReverseMap();
        }
    }
}