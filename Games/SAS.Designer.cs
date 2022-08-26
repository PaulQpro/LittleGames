using System.Resources;

namespace LittleGames.Games
{
    partial class SAS
    {
        class Beta : Form
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

            private Button Accept = new();
            private Button Cancel = new();
            private Label label = new();
            private TextBox Code = new();
            ResXResourceSet DefaultLang;
            ResXResourceSet SASBetaLang;
            string lang;
            public Beta(string lang)
            {
                this.lang = lang;
                DefaultLang = new($"Lang\\{lang}.resx");
                SASBetaLang = new($"Lang\\SAS\\Beta\\{lang}.resx");
                Accept.Text = DefaultLang.GetString("Accept");
                Cancel.Text = DefaultLang.GetString("Cancel");
                label.Text = SASBetaLang.GetString("SASBeta")+"\n"+SASBetaLang.GetString("Code")+ "\nCode is:XXXX-XXXX-XXXX-XXCD-1024";
                label.Dock = DockStyle.Top;
                label.Height = label.Height + 20;
                label.TextAlign = ContentAlignment.TopCenter;
                Code.Width = label.Width;
                Code.Height = 25;
                Code.Location = new System.Drawing.Point(0, 0);
                Text = SASBetaLang.GetString("SASBeta");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.Size = new System.Drawing.Size(400, 200);
                Accept.Size = new System.Drawing.Size(378 / 2, 25);
                Accept.Location = new System.Drawing.Point(3, Size.Height-((int)(Accept.Size.Height*2.5))-4);
                Cancel.Size = new System.Drawing.Size(378 / 2, 25);
                Cancel.Location = new System.Drawing.Point(3+Cancel.Width, Size.Height - ((int)(Accept.Size.Height * 2.5)) - 4);
                this.CancelButton = Cancel;
                this.AcceptButton = Accept;
                void cancel_handler(Object sender, EventArgs e)
                {
                    Close();
                    this.DialogResult = DialogResult.Cancel;
                }
                void accept_handler(Object sender, EventArgs e)
                {
                    if (Code.Text == "XXXX-XXXX-XXXX-XXCD-1024"){
                        Close();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Wrong beta code");
                    }
                }
                Cancel.Click += cancel_handler;
                Accept.Click += accept_handler;
                this.Controls.Add(Accept);
                this.Controls.Add(Cancel);
                this.Controls.Add(label);
                this.Controls.Add(Code);
            }
        }
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
            this.Console_window = new System.Windows.Forms.ListBox();
            this.InputLine = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Console_window
            // 
            this.Console_window.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Console_window.BackColor = System.Drawing.SystemColors.WindowText;
            this.Console_window.ForeColor = System.Drawing.SystemColors.Window;
            this.Console_window.ItemHeight = 15;
            this.Console_window.Items.AddRange(new object[] {
            "Welcome to Paulsoft© Server System™ 2022",
            "Server Launched",
            "Server listening on port 443",
            "TrackBot joined server",
            "Type \"Open\" to open server to Users"});
            this.Console_window.Location = new System.Drawing.Point(0, 0);
            this.Console_window.Margin = new System.Windows.Forms.Padding(0);
            this.Console_window.Name = "Console_window";
            this.Console_window.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Console_window.Size = new System.Drawing.Size(351, 499);
            this.Console_window.TabIndex = 0;
            // 
            // InputLine
            // 
            this.InputLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputLine.Location = new System.Drawing.Point(0, 503);
            this.InputLine.Margin = new System.Windows.Forms.Padding(0);
            this.InputLine.Name = "InputLine";
            this.InputLine.Size = new System.Drawing.Size(295, 23);
            this.InputLine.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Send.Location = new System.Drawing.Point(295, 503);
            this.Send.Margin = new System.Windows.Forms.Padding(0);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(56, 24);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Mail
            // 
            this.Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail.BackColor = System.Drawing.Color.Transparent;
            this.Mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mail.Image = global::LittleGames.Properties.Resources.Mail_Closed;
            this.Mail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mail.Location = new System.Drawing.Point(863, 12);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(64, 64);
            this.Mail.TabIndex = 3;
            this.Mail.Text = "Mail";
            this.Mail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mail.UseVisualStyleBackColor = false;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.Image = global::LittleGames.Properties.Resources.Shutdown;
            this.Close_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Close_btn.Location = new System.Drawing.Point(863, 427);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(64, 89);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Turn off Server";
            this.Close_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_Click);
            // 
            // SAS
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleGames.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 528);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.InputLine);
            this.Controls.Add(this.Console_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SAS";
            this.Text = "Paulsoft© Server System™ 2022";
            this.Load += new System.EventHandler(this.SAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Console_window;
        private TextBox InputLine;
        private Button Send;
        private Button Mail;
        private Button Close_btn;
    }
}