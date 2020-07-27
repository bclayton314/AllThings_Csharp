using AutoMapper;
using ProjectAPI.Dtos;
using ProjectAPI.Models;

namespace ProjectAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<ProjectAPICreateDto, Command>();
            CreateMap<ProjectAPIUpdateDto, Command>();
            CreateMap<Command, ProjectAPIUpdateDto>();
        }
    }
}