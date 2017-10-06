using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belatrix.Logger.Service.DTO;
using Belatrix.Logger.Transversal;
using System.ServiceModel;

namespace Belatrix.Logger.Service.Interfaces
{
    [ServiceContract]
    public interface IJobLoggerService
    {
        [OperationContract]
        Response<Boolean> SaveLogger(JobLoggerDTO logger);
    }
}
