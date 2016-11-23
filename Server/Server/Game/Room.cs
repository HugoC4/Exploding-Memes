using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Game
{
    public class Room
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public TimeSpan TurnTime { get; set; }
        public List<Card> Deck { get; set; }
        public Stack<Card> Pile { get; set; }
        public virtual List<Player> Players { get; set; }
        public virtual Player ActivePlayer { get; set; }
    }
}