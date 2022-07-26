namespace LittleGames
{
    partial class TicTacToeStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeStart));
            this.Players = new System.Windows.Forms.TrackBar();
            this.Info = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Players)).BeginInit();
            this.SuspendLayout();
            // 
            // Players
            // 
            this.Players.Location = new System.Drawing.Point(12, 12);
            this.Players.Maximum = 2;
            this.Players.Minimum = 1;
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(109, 45);
            this.Players.TabIndex = 0;
            this.Players.Value = 2;
            this.Players.Scroll += new System.EventHandler(this.Players_Scroll);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(12, 60);
            this.Info.MinimumSize = new System.Drawing.Size(109, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(109, 15);
            this.Info.TabIndex = 1;
            this.Info.Text = "Players Count: 2";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(12, 93);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(109, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.PlayTTT);
            // 
            // TicTacToeStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 125);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToeStart";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.Players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar Players;
        private Label Info;
        private Button Play;
    }
}