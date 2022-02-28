using AutoMapper;
using CM.Services.AssignmentProcessApi.Models;

namespace CM.Services.AssignmentProcessApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<AssignmentProcessDto, AssignmentProcess>();
                config.CreateMap<AssignmentProcess, AssignmentProcessDto>();
            });

            return mappingConfig;
        }
    }
}
