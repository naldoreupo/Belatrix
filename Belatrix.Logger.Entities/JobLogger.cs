

namespace Belatrix.Logger.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    public class JobLogger
    {
        public string Message { get; set; }
        public int TypeMessage { get; set; }
        public int Configuration { get; set; }
    }
}
