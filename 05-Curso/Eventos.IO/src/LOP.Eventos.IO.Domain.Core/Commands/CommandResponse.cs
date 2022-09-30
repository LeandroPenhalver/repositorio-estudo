using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Core.Commands
{
    public class CommandResponse
    {
        public static CommandResponse Ok = new CommandResponse { Successs = true };
        public static CommandResponse Fail = new CommandResponse { Successs = false };

        public CommandResponse(bool successs = false)
        {
            Successs = successs;
        }

        public bool Successs { get; set; }
    }
}
