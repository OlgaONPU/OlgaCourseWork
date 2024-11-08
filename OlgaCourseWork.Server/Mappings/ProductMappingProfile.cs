using AutoMapper;
using DataLayer.Models;
using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Models.Responses.Products;

namespace OlgaCourseWork.Server.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link)) 
                .ForMember(dest => dest.Link, opt => opt.MapFrom(src => src.Link));

            CreateMap<Door, ProductResponse>()
                .IncludeBase<Product, ProductResponse>();

            CreateMap<Accessory, ProductResponse>()
               .IncludeBase<Product, ProductResponse>(); 
            
            CreateMap<Fireplace, ProductResponse>()
               .IncludeBase<Product, ProductResponse>(); 
            
            CreateMap<HeatingSystem, ProductResponse>()
               .IncludeBase<Product, ProductResponse>();


            CreateMap<Product, ProductInfoResponse>()
           .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()))
           .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link));

            CreateMap<Door, ProductInfoResponse>()
                .IncludeBase<Product, ProductInfoResponse>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<Accessory, ProductInfoResponse>()
                .IncludeBase<Product, ProductInfoResponse>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<Fireplace, ProductInfoResponse>()
                .IncludeBase<Product, ProductInfoResponse>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<HeatingSystem, ProductInfoResponse>()
                .IncludeBase<Product, ProductInfoResponse>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<DescriptionBase, DescriptionBase>().IncludeAllDerived();
        }
    }
}
