namespace LittleGames
{
    partial class MainMenu
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
            this.Title = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NFO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.MinimumSize = new System.Drawing.Size(256, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(304, 176);
            this.Title.TabIndex = 0;
            this.Title.Text = "Paul\'s \r\nLittle Games\r\nCollection";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.Location = new System.Drawing.Point(12, 188);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(304, 70);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Enabled = false;
            this.OptionsBtn.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsBtn.Location = new System.Drawing.Point(12, 282);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(304, 69);
            this.OptionsBtn.TabIndex = 3;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(12, 374);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(304, 68);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NFO
            // 
            this.NFO.AutoSize = true;
            this.NFO.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NFO.Location = new System.Drawing.Point(3, 3);
            this.NFO.Name = "NFO";
            this.NFO.Size = new System.Drawing.Size(67, 36);
            this.NFO.TabIndex = 5;
            this.NFO.Text = "About";
            this.NFO.UseVisualStyleBackColor = true;
            this.NFO.Click += new System.EventHandler(this.NFO_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 454);
            this.Controls.Add(this.NFO);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.Title);
            this.Name = "Menu";
            this.Text = "Paul\'s Little Games Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button PlayBtn;
        private Button OptionsBtn;
        private Button ExitBtn;
        private Button NFO;
    }
}