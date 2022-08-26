namespace LittleGames
{
    partial class MemoStart
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
            this.Desk4x5 = new System.Windows.Forms.RadioButton();
            this.Desk5x6 = new System.Windows.Forms.RadioButton();
            this.Desk6x7 = new System.Windows.Forms.RadioButton();
            this.DeskSize = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.Panel();
            this.Counties = new System.Windows.Forms.RadioButton();
            this.Objects = new System.Windows.Forms.RadioButton();
            this.Colors = new System.Windows.Forms.RadioButton();
            this.DeskSizeLable = new System.Windows.Forms.Label();
            this.TypeLable = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.DeskSize.SuspendLayout();
            this.Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desk4x5
            // 
            this.Desk4x5.AutoSize = true;
            this.Desk4x5.Checked = true;
            this.Desk4x5.Location = new System.Drawing.Point(23, 3);
            this.Desk4x5.Name = "Desk4x5";
            this.Desk4x5.Size = new System.Drawing.Size(50, 19);
            this.Desk4x5.TabIndex = 0;
            this.Desk4x5.TabStop = true;
            this.Desk4x5.Text = "4 X 5";
            this.Desk4x5.UseVisualStyleBackColor = true;
            // 
            // Desk5x6
            // 
            this.Desk5x6.AutoSize = true;
            this.Desk5x6.Enabled = false;
            this.Desk5x6.Location = new System.Drawing.Point(112, 3);
            this.Desk5x6.Name = "Desk5x6";
            this.Desk5x6.Size = new System.Drawing.Size(50, 19);
            this.Desk5x6.TabIndex = 1;
            this.Desk5x6.Text = "5 X 6";
            this.Desk5x6.UseVisualStyleBackColor = true;
            // 
            // Desk6x7
            // 
            this.Desk6x7.AutoSize = true;
            this.Desk6x7.Enabled = false;
            this.Desk6x7.Location = new System.Drawing.Point(202, 3);
            this.Desk6x7.Name = "Desk6x7";
            this.Desk6x7.Size = new System.Drawing.Size(50, 19);
            this.Desk6x7.TabIndex = 2;
            this.Desk6x7.Text = "6 X 7";
            this.Desk6x7.UseVisualStyleBackColor = true;
            // 
            // DeskSize
            // 
            this.DeskSize.Controls.Add(this.Desk4x5);
            this.DeskSize.Controls.Add(this.Desk6x7);
            this.DeskSize.Controls.Add(this.Desk5x6);
            this.DeskSize.Location = new System.Drawing.Point(12, 115);
            this.DeskSize.Name = "DeskSize";
            this.DeskSize.Size = new System.Drawing.Size(289, 25);
            this.DeskSize.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.Controls.Add(this.Counties);
            this.Type.Controls.Add(this.Objects);
            this.Type.Controls.Add(this.Colors);
            this.Type.Location = new System.Drawing.Point(12, 48);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(289, 25);
            this.Type.TabIndex = 4;
            // 
            // Counties
            // 
            this.Counties.AutoSize = true;
            this.Counties.Checked = true;
            this.Counties.Location = new System.Drawing.Point(23, 3);
            this.Counties.Name = "Counties";
            this.Counties.Size = new System.Drawing.Size(72, 19);
            this.Counties.TabIndex = 0;
            this.Counties.TabStop = true;
            this.Counties.Text = "Counries";
            this.Counties.UseVisualStyleBackColor = true;
            this.Counties.Click += new System.EventHandler(this.Counties_CheckedChanged);
            // 
            // Objects
            // 
            this.Objects.AutoSize = true;
            this.Objects.Enabled = false;
            this.Objects.Location = new System.Drawing.Point(202, 3);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(65, 19);
            this.Objects.TabIndex = 2;
            this.Objects.Text = "Objects";
            this.Objects.UseVisualStyleBackColor = true;
            // 
            // Colors
            // 
            this.Colors.AutoSize = true;
            this.Colors.Location = new System.Drawing.Point(112, 3);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(59, 19);
            this.Colors.TabIndex = 1;
            this.Colors.Text = "Colors";
            this.Colors.UseVisualStyleBackColor = true;
            this.Colors.Click += new System.EventHandler(this.Colors_CheckedChanged);
            // 
            // DeskSizeLable
            // 
            this.DeskSizeLable.AutoSize = true;
            this.DeskSizeLable.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeskSizeLable.Location = new System.Drawing.Point(12, 76);
            this.DeskSizeLable.MinimumSize = new System.Drawing.Size(289, 0);
            this.DeskSizeLable.Name = "DeskSizeLable";
            this.DeskSizeLable.Size = new System.Drawing.Size(289, 36);
            this.DeskSizeLable.TabIndex = 5;
            this.DeskSizeLable.Text = "Desk Size";
            this.DeskSizeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeLable
            // 
            this.TypeLable.AutoSize = true;
            this.TypeLable.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLable.Location = new System.Drawing.Point(12, 9);
            this.TypeLable.MinimumSize = new System.Drawing.Size(289, 0);
            this.TypeLable.Name = "TypeLable";
            this.TypeLable.Size = new System.Drawing.Size(289, 36);
            this.TypeLable.TabIndex = 6;
            this.TypeLable.Text = "Type";
            this.TypeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(12, 146);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(289, 45);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MemoStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 203);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TypeLable);
            this.Controls.Add(this.DeskSizeLable);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.DeskSize);
            this.Name = "MemoStart";
            this.Text = "MemoStart";
            this.DeskSize.ResumeLayout(false);
            this.DeskSize.PerformLayout();
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Desk4x5;
        private RadioButton Desk5x6;
        private RadioButton Desk6x7;
        private Panel DeskSize;
        private Panel Type;
        private RadioButton Counties;
        private RadioButton Objects;
        private RadioButton Colors;
        private Label DeskSizeLable;
        private Label TypeLable;
        private Button Start;
    }
}