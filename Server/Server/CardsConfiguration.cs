using Server.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Xml;

namespace Server
{
    public class CardsConfiguration
    {
        private static List<Card> Cards { get; set; } = new List<Card>();
        public static void Initialize()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cards.xml"));
            
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Cards.Add(new Card
                {
                    Text = node.SelectSingleNode("text").InnerText,
                    ImageUrl = node.SelectSingleNode("imageUrl").InnerText,
                    SoundUrl = node.SelectSingleNode("soundUrl").InnerText,
                    AlwaysUse = node.SelectSingleNode("alwaysUse").InnerText == "true",
                    Type = (CardType)Enum.Parse(typeof(CardType), node.SelectSingleNode("type").InnerText)
                });
            }
        }

        public static List<Card> GetDeck(int players)
        {
            var deck = Cards;
            while (deck.Count(p => p.Type == CardType.Explode) > players - 1)
                deck.Remove(deck.First(p => p.Type == CardType.Explode));
            while (players < 4 && deck.Count(p => p.Type == CardType.Defuse) > (players + 2))
                deck.Remove(deck.First(p => p.Type == CardType.Defuse));
            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> deck)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = deck.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
            foreach (var c in deck)
                Console.WriteLine(c.Type + ": " + c.Text);
            return deck;
        }
    }
}