using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belatrix.Logger.Domain;

namespace Belatrix.Logger.Services
{
    public class LoggerService
    {
        private LoggerBDDomain loggerDomain;

        public LoggerService(LoggerBDDomain _loggerDomain)
        {
            this.loggerDomain = _loggerDomain;
        }

    }
}
