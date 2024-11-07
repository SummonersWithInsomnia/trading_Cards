using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tradingCards
{
    public partial class playerCard : Form
    {
        public playerCard()
        {
            InitializeComponent();
        }

        public void DisplayPlayerData(Player player)
        {
            playerName.Text = player.playerName;
            teamName.Text = player.teamName;
            notableStat.Text = player.notableStat;
            cardPrice.Text = $"${player.cardPrice:N0}";
            cardType.Text = player.cardType;
            bgChange.BackColor = Color.FromName(player.cardColor);
            cardValue.Value = player.cardValue;

            if (System.IO.File.Exists(player.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(player.ImagePath);
            }
            else
            {
                pictureBox1.Image = null; 
            }
        }

    }
}
