namespace LittleGames.Games
{
    partial class TicTacToe
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
            this.Desk = new System.Windows.Forms.Panel();
            this.Cell0 = new LittleGames.Cell();
            this.Cell8 = new LittleGames.Cell();
            this.Cell7 = new LittleGames.Cell();
            this.Cell6 = new LittleGames.Cell();
            this.Cell5 = new LittleGames.Cell();
            this.Cell4 = new LittleGames.Cell();
            this.Cell3 = new LittleGames.Cell();
            this.Cell2 = new LittleGames.Cell();
            this.Cell1 = new LittleGames.Cell();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Desk.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desk
            // 
            this.Desk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Desk.Controls.Add(this.Cell0);
            this.Desk.Controls.Add(this.Cell8);
            this.Desk.Controls.Add(this.Cell7);
            this.Desk.Controls.Add(this.Cell6);
            this.Desk.Controls.Add(this.Cell5);
            this.Desk.Controls.Add(this.Cell4);
            this.Desk.Controls.Add(this.Cell3);
            this.Desk.Controls.Add(this.Cell2);
            this.Desk.Controls.Add(this.Cell1);
            this.Desk.Location = new System.Drawing.Point(209, 23);
            this.Desk.Name = "Desk";
            this.Desk.Size = new System.Drawing.Size(402, 402);
            this.Desk.TabIndex = 2;
            // 
            // Cell0
            // 
            this.Cell0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell0.Location = new System.Drawing.Point(3, 3);
            this.Cell0.Name = "Cell0";
            this.Cell0.Size = new System.Drawing.Size(128, 128);
            this.Cell0.TabIndex = 3;
            this.Cell0.UseVisualStyleBackColor = true;
            this.Cell0.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell8
            // 
            this.Cell8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell8.Location = new System.Drawing.Point(271, 271);
            this.Cell8.Name = "Cell8";
            this.Cell8.Size = new System.Drawing.Size(128, 128);
            this.Cell8.TabIndex = 11;
            this.Cell8.UseVisualStyleBackColor = true;
            this.Cell8.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell7
            // 
            this.Cell7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell7.Location = new System.Drawing.Point(137, 271);
            this.Cell7.Name = "Cell7";
            this.Cell7.Size = new System.Drawing.Size(128, 128);
            this.Cell7.TabIndex = 10;
            this.Cell7.UseVisualStyleBackColor = true;
            this.Cell7.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell6
            // 
            this.Cell6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell6.Location = new System.Drawing.Point(3, 271);
            this.Cell6.Name = "Cell6";
            this.Cell6.Size = new System.Drawing.Size(128, 128);
            this.Cell6.TabIndex = 9;
            this.Cell6.UseVisualStyleBackColor = true;
            this.Cell6.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell5
            // 
            this.Cell5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell5.Location = new System.Drawing.Point(271, 137);
            this.Cell5.Name = "Cell5";
            this.Cell5.Size = new System.Drawing.Size(128, 128);
            this.Cell5.TabIndex = 8;
            this.Cell5.UseVisualStyleBackColor = true;
            this.Cell5.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell4
            // 
            this.Cell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell4.Location = new System.Drawing.Point(137, 137);
            this.Cell4.Name = "Cell4";
            this.Cell4.Size = new System.Drawing.Size(128, 128);
            this.Cell4.TabIndex = 7;
            this.Cell4.UseVisualStyleBackColor = true;
            this.Cell4.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell3
            // 
            this.Cell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell3.Location = new System.Drawing.Point(3, 137);
            this.Cell3.Name = "Cell3";
            this.Cell3.Size = new System.Drawing.Size(128, 128);
            this.Cell3.TabIndex = 6;
            this.Cell3.UseVisualStyleBackColor = true;
            this.Cell3.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell2
            // 
            this.Cell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell2.Location = new System.Drawing.Point(271, 3);
            this.Cell2.Name = "Cell2";
            this.Cell2.Size = new System.Drawing.Size(128, 128);
            this.Cell2.TabIndex = 5;
            this.Cell2.UseVisualStyleBackColor = true;
            this.Cell2.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Cell1
            // 
            this.Cell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell1.Location = new System.Drawing.Point(137, 3);
            this.Cell1.Name = "Cell1";
            this.Cell1.Size = new System.Drawing.Size(128, 128);
            this.Cell1.TabIndex = 4;
            this.Cell1.UseVisualStyleBackColor = true;
            this.Cell1.Click += new System.EventHandler(this.Cell_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(53, 15);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "\'X\' Move";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 415);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(713, 415);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Desk);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.Desk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel Desk;
        private Cell Cell0;
        private Label InfoLabel;
        private Cell Cell8;
        private Cell Cell7;
        private Cell Cell6;
        private Cell Cell5;
        private Cell Cell4;
        private Cell Cell3;
        private Cell Cell2;
        private Cell Cell1;
        private Button Reset;
        private Button CloseBtn;
    }
}