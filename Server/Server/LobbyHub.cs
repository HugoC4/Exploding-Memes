using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Server.Connection;
using System.IO;

namespace Server
{
    public class LobbyHub : Hub
    {
        public static Dictionary<string, ConnectionInformation> Users { get; set; } = new Dictionary<string, ConnectionInformation>();
        private static string _manifest { get; set; }
        public string GetManifest()
        {
            return _manifest ?? _manifest = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "manifest.json"));
        }
        public override Task OnConnected()
        {
            // new user
            if (!Users.Any(kv => kv.Key == Context.ConnectionId))
            {
                Users.Add(Context.ConnectionId, new ConnectionInformation
                {
                    Id = Context.ConnectionId,
                    State = ConnectionState.Loading
                });
            } //existing user
            else 
            {
                // Handle Room stuff
            }
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            if (!stopCalled) 
            {
                Users[Context.ConnectionId].State = ConnectionState.Disconnected;
                // Handle Room stuff?
            }
            else
                Users.Remove(Context.ConnectionId);
            
            return base.OnDisconnected(stopCalled);
        }

    }
}