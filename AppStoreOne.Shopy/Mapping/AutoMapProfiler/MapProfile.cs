using AppStoreOne.Dtos.Dtos;
using AppStoreOne.Dtos.EstateTypeDtos;
using AppStoreOne.Entities.Concrete;
using AutoMapper;

namespace AppStoreOne.Shopy.Mapping.AutoMapProfiler
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserListDto, User>();
            CreateMap<User, UserListDto>();
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserAddDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<Customer, CustomerListDto>();
            CreateMap<CustomerListDto, Customer>();
            CreateMap<Customer, CustomerAddDto>();
            CreateMap<CustomerAddDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();
            CreateMap<Customer, CustomerUpdateDto>();
            CreateMap<Estate, EstateListDto>();
            CreateMap<EstateListDto, Estate>();
            CreateMap<EstateDaireDto, Estate>();
            CreateMap<EstateDukkanDto, Estate>();
            CreateMap<EstateArsaDto, Estate>();
            CreateMap<Estate,EstateDaireDto>();
            CreateMap<Estate, EstateDukkanDto>();
            CreateMap<Estate,EstateArsaDto>();

        }
    }
}
