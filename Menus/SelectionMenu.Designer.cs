namespace LittleGames
{
    partial class SelectionMenu
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
            this.TicTacToe_start = new System.Windows.Forms.Button();
            this.Memo_Start = new System.Windows.Forms.Button();
            this.CS = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SAS_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicTacToe_start
            // 
            this.TicTacToe_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TicTacToe_start.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicTacToe_start.Location = new System.Drawing.Point(12, 12);
            this.TicTacToe_start.Name = "TicTacToe_start";
            this.TicTacToe_start.Size = new System.Drawing.Size(128, 61);
            this.TicTacToe_start.TabIndex = 0;
            this.TicTacToe_start.Text = "Tic-Tac-Toe";
            this.TicTacToe_start.UseVisualStyleBackColor = true;
            this.TicTacToe_start.Click += new System.EventHandler(this.TicTacToe_start_Click);
            // 
            // Memo_Start
            // 
            this.Memo_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Memo_Start.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Memo_Start.Location = new System.Drawing.Point(146, 12);
            this.Memo_Start.Name = "Memo_Start";
            this.Memo_Start.Size = new System.Drawing.Size(128, 61);
            this.Memo_Start.TabIndex = 5;
            this.Memo_Start.Text = "Memos";
            this.Memo_Start.UseVisualStyleBackColor = true;
            this.Memo_Start.Click += new System.EventHandler(this.Memo_Start_Click);
            // 
            // CS
            // 
            this.CS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CS.Enabled = false;
            this.CS.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CS.Location = new System.Drawing.Point(414, 12);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(128, 61);
            this.CS.TabIndex = 6;
            this.CS.Text = "Coming Soon";
            this.CS.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(660, 403);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(128, 35);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.Back);
            // 
            // SAS_Start
            // 
            this.SAS_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SAS_Start.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SAS_Start.Location = new System.Drawing.Point(280, 12);
            this.SAS_Start.Name = "SAS_Start";
            this.SAS_Start.Size = new System.Drawing.Size(128, 61);
            this.SAS_Start.TabIndex = 8;
            this.SAS_Start.Text = "Server Admin\r\nSimulator\r\n";
            this.SAS_Start.UseVisualStyleBackColor = true;
            this.SAS_Start.Click += new System.EventHandler(this.SAS_Start_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SAS_Start);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.Memo_Start);
            this.Controls.Add(this.TicTacToe_start);
            this.Name = "SelectionMenu";
            this.Text = "SelectionMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button TicTacToe_start;
        private Button Memo_Start;
        private Button CS;
        private Button BackBtn;
        private Button SAS_Start;
    }
}