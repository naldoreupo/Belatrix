using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belatrix.Logger.Domain.Entities;
using Belatrix.Logger.Transversal;

namespace Belatrix.Logger.Interfaces
{
    public interface IJobloggerDomain
    {
        Response<Boolean> SaveLogger(JobLogger logger);
    }
}
