using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Connection
{
    public enum ConnectionState
    {
        Loading,
        Lobby,
        InGame,
        Spectating,
        Disconnected
    }
}