using Api.WebApi.Dtos.FeatureDtos;
using Api.WebApi.Dtos.MessageDtos;
using Api.WebApi.Dtos.ProductDtos;
using Api.WebApi.Entities;
using AutoMapper;

namespace Api.WebApi.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<message, ResultMessageDto>().ReverseMap();
            CreateMap<message, CreateFeatureDto>().ReverseMap();
            CreateMap<message, UpdateFeatureDto>().ReverseMap();
            CreateMap<message, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Product, CreateFeatureDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x => x.CategoryName, y => y.MapFrom(z =>z.Category.CategoryName)).ReverseMap();
        }

    }
}
