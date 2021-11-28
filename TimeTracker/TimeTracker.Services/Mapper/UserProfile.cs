using AutoMapper;
using TimeTracker.DataAccess.Entities;
using TimeTracker.Services.Models.User;

namespace TimeTracker.Services.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, User>();
        }
    }
}
