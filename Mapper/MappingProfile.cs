using AutoMapper;
using Models;
using WebApi.DTOModels;

namespace WebApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Comment, CommentDTO>();
        }
    }
}
