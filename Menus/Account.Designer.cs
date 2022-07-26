namespace LittleGames
{
    partial class Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SingIn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.MinimumSize = new System.Drawing.Size(240, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sing In\r\nor\r\nCreate an Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(15, 198);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(210, 23);
            this.UsernameBox.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(15, 175);
            this.UserLabel.MinimumSize = new System.Drawing.Size(210, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(210, 20);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLable.Location = new System.Drawing.Point(15, 299);
            this.PasswordLable.MinimumSize = new System.Drawing.Size(210, 0);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(210, 20);
            this.PasswordLable.TabIndex = 2;
            this.PasswordLable.Text = "Password";
            this.PasswordLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(15, 322);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(210, 23);
            this.PasswordBox.TabIndex = 1;
            // 
            // SingIn
            // 
            this.SingIn.Location = new System.Drawing.Point(15, 438);
            this.SingIn.Name = "SingIn";
            this.SingIn.Size = new System.Drawing.Size(105, 23);
            this.SingIn.TabIndex = 3;
            this.SingIn.Text = "Sing in";
            this.SingIn.UseVisualStyleBackColor = true;
            this.SingIn.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(120, 438);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(105, 23);
            this.Register.TabIndex = 4;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(240, 473);
            this.ControlBox = false;
            this.Controls.Add(this.Register);
            this.Controls.Add(this.SingIn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Account";
            this.ShowInTaskbar = false;
            this.Text = "Account";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox UsernameBox;
        private Label UserLabel;
        private Label PasswordLable;
        private TextBox PasswordBox;
        private Button SingIn;
        private Button Register;
    }
}