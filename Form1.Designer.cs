namespace tradingCards
{
    partial class cardTray
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            showCard1 = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 60);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(339, 4);
            label2.Name = "label2";
            label2.Size = new Size(297, 50);
            label2.TabIndex = 3;
            label2.Text = "Trading Cards";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 581);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 35);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(400, 6);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 2;
            label1.Text = "© Summoners with Insomnia";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(showCard1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 521);
            panel3.TabIndex = 2;
            // 
            // showCard1
            // 
            showCard1.BackColor = Color.Moccasin;
            showCard1.FlatStyle = FlatStyle.System;
            showCard1.ForeColor = SystemColors.ActiveCaptionText;
            showCard1.Location = new Point(12, 6);
            showCard1.Name = "showCard1";
            showCard1.Size = new Size(242, 42);
            showCard1.TabIndex = 3;
            showCard1.Text = "Kobe Bryant";
            showCard1.UseVisualStyleBackColor = false;
            showCard1.Click += showCard1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(260, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 521);
            panel4.TabIndex = 3;
            // 
            // cardTray
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 616);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "cardTray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Button showCard1;
        private Panel panel4;
    }
}
