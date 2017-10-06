using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DTO = Belatrix.Logger.Service.DTO;
using DOE = Belatrix.Logger.Domain.Entities;
using DAE = Belatrix.Logger.Repository.Entities;


namespace Belatrix.Logger.Transversal
{
    public static class Maps
    {
        public static void register()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<DTO.JobLoggerDTO, DOE.JobLogger>();
                cfg.CreateMap<DOE.JobLogger, DTO.JobLoggerDTO>();

                cfg.CreateMap<DTO.JobLoggerDTO, DAE.JobLogger>();
                cfg.CreateMap<DAE.JobLogger, DTO.JobLoggerDTO>();

                cfg.CreateMap<DOE.JobLogger, DAE.JobLogger>();
                cfg.CreateMap<DAE.JobLogger, DOE.JobLogger>();
            });

            //IMapper mapper = config.CreateMapper();
            //return mapper;
        }
    }
}
