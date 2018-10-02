using AutoMapper;
using WebApi.Core.Dto;

namespace WebApi.Core.Service.Mappings
{
    public static class Mapping
    {
        public static void Configure()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.ForAllMaps((typeMap, conf) =>
                {
                    conf.PreserveReferences();
                });

                mapper.ApplicationMapping();
            });
        }

        private static void ApplicationMapping(this IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<TestDto, TestDto>().ReverseMap();
        }
    }
}
