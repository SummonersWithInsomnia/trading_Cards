namespace tradingCards
{
    public partial class cardTray : Form
    {

        private Dictionary<string, Player> playerData;
        public cardTray()
        {

            InitializeComponent();

            //NBA players dictionary
            playerData = new Dictionary<string, Player>
        {
            { "Kobe Bryant", new Player("Kobe Bryant", "Los Angeles Lakers", "Purple", "5 NBA Championships", 50000, "Rookie Card", 95, "Images/player1.jpg") },
            { "Michael Jordan", new Player("Michael Jordan", "Chicago Bulls", "Red", "6 NBA Championships", 200000, "1986 Fleer Rookie", 100, "Images/player2.jpg") },
            { "LeBron James", new Player("LeBron James", "Los Angeles Lakers", "Purple", "4 NBA Championships", 70000, "2003 Upper Deck SP Rookie", 90, "Images/player3.jpg") },
            { "Stephen Curry", new Player("Stephen Curry", "Golden State Warriors", "Blue", "3 NBA Championships", 30000, "Autographed Panini", 85, "Images/player4.jpg") },
            { "Kevin Durant", new Player("Kevin Durant", "Brooklyn Nets", "Black", "2 NBA Championships", 15000, "2007 Topps Chrome Rookie", 80, "Images/player5.jpg") },
            { "Giannis Antetokounmpo", new Player("Giannis Antetokounmpo", "Milwaukee Bucks", "Green", "1 NBA Championship", 12000, "Panini Prizm Silver", 75, "Images/player6.jpg") },
            { "Kawhi Leonard", new Player("Kawhi Leonard", "Los Angeles Clippers", "Red", "2 NBA Championships", 10000, "2012 Panini Prizm Rookie", 70, "Images/player7.jpg") },
            { "Luka Dončić", new Player("Luka Dončić", "Dallas Mavericks", "Blue", "0 NBA Championships", 5000, "2018 Panini Prizm Rookie", 65, "Images/player8.jpg") },
            { "Nikola Jokić", new Player("Nikola Jokić", "Denver Nuggets", "Blue", "0 NBA Championships", 4000, "Panini Prizm Silver", 60, "Images/player9.jpg") },
            { "Zion Williamson", new Player("Zion Williamson", "New Orleans Pelicans", "Red", "0 NBA Championships", 3500, "Panini National Treasures", 55, "Images/player10.jpg") }
        };

            showCard1.Click += (s, e) => DisplayPlayerDetails("Kobe Bryant");
            showCard2.Click += (s, e) => DisplayPlayerDetails("LeBron James");
            showCard3.Click += (s, e) => DisplayPlayerDetails("Luka Dončić");
            showCard4.Click += (s, e) => DisplayPlayerDetails("Stephen Curry");
            showCard5.Click += (s, e) => DisplayPlayerDetails("Michael Jordan");
            showCard6.Click += (s, e) => DisplayPlayerDetails("Giannis Antetokounmpo");
            showCard7.Click += (s, e) => DisplayPlayerDetails("Kawhi Leonard");
            showCard8.Click += (s, e) => DisplayPlayerDetails("Nikola Jokić");
            showCard9.Click += (s, e) => DisplayPlayerDetails("Kevin Durant");
            showCard10.Click += (s, e) => DisplayPlayerDetails("Zion Williamson");
        }

        private void DisplayPlayerDetails(string playerName)
        {
            if (playerData.TryGetValue(playerName, out Player player))
            {
                playerCard frm = new playerCard();
                frm.DisplayPlayerData(player);
                frm.TopLevel = false;
                frm.Parent = panel4;
                frm.Dock = DockStyle.Fill;
                panel4.Controls.Clear();
                panel4.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Player not found.");
            }
            

        }
    }

}