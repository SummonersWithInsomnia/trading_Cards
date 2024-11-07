using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradingCards
{
    public class Player
    {
        public string playerName { get; set; }
        public string teamName { get; set; }
        public string cardColor { get; set; }
        public string notableStat { get; set; }
        public int cardPrice { get; set; }
        public string cardType { get; set; }
        public int cardValue { get; set; }
        public string ImagePath { get; set; }

        public Player(string playerName, string teamName, string cardColor, string notableStat, int cardPrice, string cardType, int cardValue, string imagePath)
        {
            this.playerName = playerName;
            this.teamName = teamName;
            this.cardColor = cardColor;
            this.notableStat = notableStat;
            this.cardPrice = cardPrice;
            this.cardType = cardType;
            this.cardValue = cardValue;
            this.ImagePath = imagePath;
        }
    }
}
