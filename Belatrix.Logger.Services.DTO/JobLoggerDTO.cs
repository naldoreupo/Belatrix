using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Belatrix.Logger.Service.DTO
{
    [DataContract]
    public class JobLoggerDTO
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int TypeMessage { get; set; }

        [DataMember]
        public int Configuration { get; set; }    
    }
}
