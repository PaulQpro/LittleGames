using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleGames.Games;

namespace LittleGames
{
    public partial class TicTacToeStart : Form
    {
        string lang;
        public TicTacToeStart(string lang)
        {
            this.lang = lang;
            InitializeComponent();
        }

        private void PlayTTT(object sender, EventArgs e)
        {
            if(Players.Value == 1)
            {
                MessageBox.Show("Bot is not available now", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Players.Value = 2;
            }
            ShowInTaskbar = false;
            Visible = false;
            new TicTacToe(Players.Value, lang).ShowDialog(this);
        }

        private void Players_Scroll(object sender, EventArgs e)
        {
            Info.Text = $"Players Count: {Players.Value}";
        }
    }
}
