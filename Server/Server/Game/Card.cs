using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Game
{
    public class Card
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public bool AlwaysUse { get; set; } = false;
        public string ImageUrl { get; set; }
        public string SoundUrl { get; set; }
    }
}