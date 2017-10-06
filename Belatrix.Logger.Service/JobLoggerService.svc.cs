using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Belatrix.Logger.Domain.Entities;
using Belatrix.Logger.Service.Interfaces;
using DTO = Belatrix.Logger.Service.DTO;
using AutoMapper;
using Belatrix.Logger.Transversal;
using Belatrix.Logger.Interfaces;
using Autofac.Features.Indexed;

namespace Belatrix.Logger.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobLoggerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JobLoggerService.svc or JobLoggerService.svc.cs at the Solution Explorer and start debugging.
    public class JobLoggerService : IJobLoggerService
    {
        private readonly IIndex<Configuration, IJobloggerDomain> iLoggerDomain;

        public JobLoggerService(IIndex<Configuration, IJobloggerDomain> _iLoggerDomain)
        {
            this.iLoggerDomain = _iLoggerDomain;
        }
        
        public Response<Boolean> SaveLogger(DTO.JobLoggerDTO logger)
        {
            return iLoggerDomain[(Configuration)logger.Configuration].SaveLogger(Mapper.Map<JobLogger>(logger));
        }

    }
}

