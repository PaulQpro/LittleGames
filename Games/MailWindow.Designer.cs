namespace LittleGames.Games
{
    partial class MailWindow
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
            this.Incoming = new System.Windows.Forms.TabControl();
            this.FromBoss = new System.Windows.Forms.TabPage();
            this.FormUsers = new System.Windows.Forms.TabPage();
            this.FromAnon = new System.Windows.Forms.TabPage();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Incoming.SuspendLayout();
            this.FromBoss.SuspendLayout();
            this.SuspendLayout();
            // 
            // Incoming
            // 
            this.Incoming.Controls.Add(this.FromBoss);
            this.Incoming.Controls.Add(this.FormUsers);
            this.Incoming.Controls.Add(this.FromAnon);
            this.Incoming.Location = new System.Drawing.Point(12, 12);
            this.Incoming.Name = "Incoming";
            this.Incoming.SelectedIndex = 0;
            this.Incoming.Size = new System.Drawing.Size(776, 426);
            this.Incoming.TabIndex = 0;
            // 
            // FromBoss
            // 
            this.FromBoss.Controls.Add(this.domainUpDown1);
            this.FromBoss.Location = new System.Drawing.Point(4, 24);
            this.FromBoss.Name = "FromBoss";
            this.FromBoss.Padding = new System.Windows.Forms.Padding(3);
            this.FromBoss.Size = new System.Drawing.Size(768, 398);
            this.FromBoss.TabIndex = 0;
            this.FromBoss.Text = "From Boss";
            this.FromBoss.UseVisualStyleBackColor = true;
            // 
            // FormUsers
            // 
            this.FormUsers.Location = new System.Drawing.Point(4, 24);
            this.FormUsers.Name = "FormUsers";
            this.FormUsers.Padding = new System.Windows.Forms.Padding(3);
            this.FormUsers.Size = new System.Drawing.Size(768, 398);
            this.FormUsers.TabIndex = 1;
            this.FormUsers.Text = "From Users";
            this.FormUsers.UseVisualStyleBackColor = true;
            // 
            // FromAnon
            // 
            this.FromAnon.Location = new System.Drawing.Point(4, 24);
            this.FromAnon.Name = "FromAnon";
            this.FromAnon.Padding = new System.Windows.Forms.Padding(3);
            this.FromAnon.Size = new System.Drawing.Size(768, 398);
            this.FromAnon.TabIndex = 2;
            this.FromAnon.Text = "Unknow Senders";
            this.FromAnon.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(246, 202);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 23);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // MailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Incoming);
            this.Name = "MailWindow";
            this.Text = "MailWindow";
            this.Incoming.ResumeLayout(false);
            this.FromBoss.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Incoming;
        private TabPage FromBoss;
        private DomainUpDown domainUpDown1;
        private TabPage FormUsers;
        private TabPage FromAnon;
    }
}