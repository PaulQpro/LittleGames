using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleGames;

namespace LittleGames.Games
{
    public partial class TicTacToe : Form
    {

        private bool X = true;
        private bool end = false;
        private int filled = 0;
        private static Cell[][] cells  = new Cell[3][];
        private int players;
        Bot bot = new Bot(cells);
        public TicTacToe(int players)
        {
            this.players = players;
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                cells[i] = new Cell[3];
            }
        }

        private void Win(char sym)
        {
            for(int i = 0; i < 3; i++)
            {
                if (cells[i][0].sym == sym && cells[i][1].sym == sym && cells[i][2].sym == sym)
                {
                    Console.WriteLine("m1");
                    end = true;
                    InfoLabel.Text = "'" + sym + "' wins!";
                }
                if (cells[0][i].sym == sym && cells[1][i].sym == sym && cells[2][i].sym == sym)
                {
                    Console.WriteLine("m2");
                    end = true;
                    InfoLabel.Text = "'" + sym + "' wins!";
                }
            }
            if ((cells[0][0].sym == sym || cells[0][2].sym == sym) && cells[1][1].sym == sym && (cells[2][0].sym == sym || cells[2][2].sym == sym))
            {
                Console.WriteLine("m3");
                end = true;
                InfoLabel.Text = "'" + sym + "' wins!";
            }
        }

        private void Cell_Click(Object sender, EventArgs e)
        {
            string resX = @"Resources.resx";
            using ResXResourceSet resxSet = new(resX);
            Image cross = (Image)resxSet.GetObject(@"cross", true);
            Image zero = (Image)resxSet.GetObject(@"zero", true);
            Cell cell = sender as Cell;
            if (cell != null && !cell.full && !end && players == 2)
                {
                if (X)
                {
                    X = false;
                    InfoLabel.Text = "'0' Move";
                    cell.BackgroundImage = cross;
                    cell.sym = 'X';
                    Win('X');
                }
                else
                {
                    X = true;
                    InfoLabel.Text = "'X' Move";
                    cell.BackgroundImage = zero;
                    cell.sym = '0';
                    Win('0');
                }
                cell.full = true;
                filled++;
            }
            else if (cell != null && !cell.full && !end && players == 1)
            {
                cell.BackgroundImage = cross;
                Win('X');
                int[] botCoords = bot.Work();
                cells[botCoords[0]][botCoords[1]].BackgroundImage = zero;
                Win('0');
            }
            else if (end)
            {
                return;
            }
            if(filled == 9 && !end)
            {
                InfoLabel.Text = "Draw!";
                end = true;
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            cells[0][0] = Cell0;
            cells[0][1] = Cell1;
            cells[0][2] = Cell2;
            cells[1][0] = Cell3;
            cells[1][1] = Cell4;
            cells[1][2] = Cell5;
            cells[2][0] = Cell6;
            cells[2][1] = Cell7;
            cells[2][2] = Cell8;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            foreach(Cell[] cellS in cells){
                foreach (Cell cell in cellS)
                {
                    cell.BackgroundImage = null;
                    cell.full = false;
                    cell.sym = ' ';
                    filled = 0;
                }
            }
            end = false;
            X = true;
            InfoLabel.Text = "'X' Move";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
