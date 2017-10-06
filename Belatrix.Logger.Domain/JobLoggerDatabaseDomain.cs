using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belatrix.Logger.Repository;
using DOE = Belatrix.Logger.Domain.Entities;
using Belatrix.Logger.Interfaces;
using Belatrix.Logger.Transversal;
using DAE = Belatrix.Logger.Repository.Entities;
using AutoMapper;
using Belatrix.Logger.IRepository;

namespace Belatrix.Logger.Domain
{
    public class JobLoggerDatabaseDomain : IJobloggerDomain
    {
        private readonly IJobLoggerRepository loggerRepository;

        public JobLoggerDatabaseDomain(IJobLoggerRepository _loggerRepository)
        {
            this.loggerRepository = _loggerRepository;
        }
        public Response<Boolean> SaveLogger(DOE.JobLogger jobLogger)
        {
            return loggerRepository.SaveLogger(Mapper.Map<DAE.JobLogger>(jobLogger));
        }
    }
}