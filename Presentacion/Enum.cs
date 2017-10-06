using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belatrix.Logger.App
{
    public enum Configuration
    {
        File,
        Console,
        Database
    }

    public enum TypeMessage
    {
        Message,
        Warning,
        Error
    }
}

