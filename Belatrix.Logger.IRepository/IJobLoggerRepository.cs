using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belatrix.Logger.Transversal;
using Belatrix.Logger.Repository.Entities;

namespace Belatrix.Logger.IRepository
{
    public interface IJobLoggerRepository
    {
        Response<Boolean> SaveLogger(JobLogger logger);
    }
}
