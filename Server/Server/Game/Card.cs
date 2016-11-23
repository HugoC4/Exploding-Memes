using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Game
{
    public class Card
    {
        public string Text { get; set; }
        public CardType Type { get; set; }
        public bool AlwaysUse { get; set; } = false;
        public string ImageUrl { get; set; }
        public string SoundUrl { get; set; }
    }

    public enum CardType
    {
        Defuse,
        Explode,
        Skip,
        Attack,
        Nope,
        Shuffle,
        Future,
        Favor,
        NormalFace,
        NormalPepe,
        NormalNyan,
        NormalLong,
        NormalWebsite
    }
}