using AutoMapper;
using Belatrix.Logger.IRepository;
using Belatrix.Logger.Repository.Entities;
using Belatrix.Logger.Transversal;
using System;

namespace Belatrix.Logger.Repository
{
    public class JobLoggerRepository : BaseRepository<JobLogger>, IJobLoggerRepository
    {
        public Response<Boolean> SaveLogger(Entities.JobLogger logger)
        {
            return Save(Mapper.Map<JobLogger>(logger));
        }
    }
}
