namespace OlgaCourseWork.Server.Mappings
{
    using AutoMapper;
    using OlgaCourseWork.Common.Commands;
    using OlgaCourseWork.Common.Models.Requests;

    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderRequest, CreateOrderCommand>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.ClientName))
                .ForMember(dest => dest.ClientPhone, opt => opt.MapFrom(src => src.ClientPhone))
                .ReverseMap();
        }
    }
}
