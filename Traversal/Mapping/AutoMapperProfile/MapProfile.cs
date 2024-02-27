using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;


namespace Traversal.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementDTOs,Announcement>();
            CreateMap<Announcement,AnnouncementDTOs>();

            CreateMap<AppUserRegisterDTOs,AppUser>();
            CreateMap<AppUser,AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs,AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

            CreateMap<AnnouncementListDTO, Announcement>();
            CreateMap<Announcement, AnnouncementListDTO>();

        }
    }
}
