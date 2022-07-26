using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleGames;
using LittleGames.Games;

namespace LittleGames
{
    public partial class SelectionMenu : Form
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void TicTacToe_start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new TicTacToeStart().ShowDialog(this);
        }

        private void Memo_Start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new MemoCountries().ShowDialog(this);
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }

        private void SAS_Start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new SAS().ShowDialog(this);
        }
    }
}
