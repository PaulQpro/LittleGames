namespace LittleGames
{
    partial class Options
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
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.Eng = new System.Windows.Forms.RadioButton();
            this.Rus = new System.Windows.Forms.RadioButton();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageLabel.Location = new System.Drawing.Point(12, 9);
            this.LanguageLabel.MinimumSize = new System.Drawing.Size(304, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(304, 25);
            this.LanguageLabel.TabIndex = 1;
            this.LanguageLabel.Text = "Language";
            this.LanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Eng
            // 
            this.Eng.AutoSize = true;
            this.Eng.Checked = true;
            this.Eng.Location = new System.Drawing.Point(12, 37);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(63, 19);
            this.Eng.TabIndex = 2;
            this.Eng.Text = "English";
            this.Eng.UseVisualStyleBackColor = true;
            // 
            // Rus
            // 
            this.Rus.AutoSize = true;
            this.Rus.Location = new System.Drawing.Point(81, 37);
            this.Rus.Name = "Rus";
            this.Rus.Size = new System.Drawing.Size(70, 19);
            this.Rus.TabIndex = 2;
            this.Rus.Text = "Русский";
            this.Rus.UseVisualStyleBackColor = true;
            // 
            // Apply_btn
            // 
            this.Apply_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply_btn.Location = new System.Drawing.Point(0, 431);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(328, 23);
            this.Apply_btn.TabIndex = 3;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 454);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.Rus);
            this.Controls.Add(this.Eng);
            this.Controls.Add(this.LanguageLabel);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LanguageLabel;
        private RadioButton Eng;
        private RadioButton Rus;
        private Button Apply_btn;
    }
}