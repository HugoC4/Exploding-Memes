using Server.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Connection
{
    public class ConnectionInformation
    {
        public string Id { get; set; }
        public ConnectionState State { get; set; }
        public virtual Player Player { get; set; }
        public virtual Room Room { get; set; }
    }
}