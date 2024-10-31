namespace tradingCards
{
    public partial class cardTray : Form
    {
        public cardTray()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showCard1_Click(object sender, EventArgs e)
        {
            playerCard frm = new playerCard();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }
    }
}
