namespace tradingCards
{
    partial class playerCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bgChange = new Panel();
            cardValue = new ProgressBar();
            cardPrice = new Label();
            notableStat = new Label();
            teamName = new Label();
            playerName = new Label();
            cardType = new Label();
            pictureBox1 = new PictureBox();
            bgChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bgChange
            // 
            bgChange.Controls.Add(cardValue);
            bgChange.Controls.Add(cardPrice);
            bgChange.Controls.Add(notableStat);
            bgChange.Controls.Add(teamName);
            bgChange.Controls.Add(playerName);
            bgChange.Controls.Add(cardType);
            bgChange.Controls.Add(pictureBox1);
            bgChange.Dock = DockStyle.Fill;
            bgChange.Location = new Point(0, 0);
            bgChange.Name = "bgChange";
            bgChange.Size = new Size(315, 450);
            bgChange.TabIndex = 0;
            // 
            // cardValue
            // 
            cardValue.Location = new Point(62, 387);
            cardValue.Name = "cardValue";
            cardValue.Size = new Size(188, 30);
            cardValue.TabIndex = 6;
            // 
            // cardPrice
            // 
            cardPrice.AutoSize = true;
            cardPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardPrice.Location = new Point(104, 324);
            cardPrice.Name = "cardPrice";
            cardPrice.Size = new Size(100, 28);
            cardPrice.TabIndex = 5;
            cardPrice.Text = "Card Price";
            // 
            // notableStat
            // 
            notableStat.AutoSize = true;
            notableStat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notableStat.Location = new Point(96, 296);
            notableStat.Name = "notableStat";
            notableStat.Size = new Size(122, 28);
            notableStat.TabIndex = 4;
            notableStat.Text = "Notable Stat";
            // 
            // teamName
            // 
            teamName.AutoSize = true;
            teamName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamName.Location = new Point(99, 240);
            teamName.Name = "teamName";
            teamName.Size = new Size(114, 28);
            teamName.TabIndex = 3;
            teamName.Text = "Team Name";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerName.Location = new Point(97, 212);
            playerName.Name = "playerName";
            playerName.Size = new Size(122, 28);
            playerName.TabIndex = 2;
            playerName.Text = "Player Name";
            // 
            // cardType
            // 
            cardType.Anchor = AnchorStyles.Top;
            cardType.AutoSize = true;
            cardType.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardType.Location = new Point(87, 18);
            cardType.Name = "cardType";
            cardType.Size = new Size(140, 38);
            cardType.TabIndex = 1;
            cardType.Text = "Card Type";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(93, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // playerCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(bgChange);
            FormBorderStyle = FormBorderStyle.None;
            Name = "playerCard";
            Text = "Form3";
            bgChange.ResumeLayout(false);
            bgChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgChange;
        private Label cardType;
        private PictureBox pictureBox1;
        private Label cardPrice;
        private Label notableStat;
        private Label teamName;
        private Label playerName;
        private ProgressBar cardValue;
    }
}