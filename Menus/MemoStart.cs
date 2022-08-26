using LittleGames.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleGames
{
    public partial class MemoStart : Form
    {
        string lang;
        public MemoStart(string lang)
        {
            InitializeComponent();
            this.lang = lang;
        }
        string[] selected = { "Countries", "4X5" };
        string[] type = { "Countries", "Colors", "Objects" };
        string[] size = { "4X5", "5X6", "6X7" };
        string[] CountriesSizes = { "4X5" };
        string[] ColorsSizes = { "6X7" };
        private void Start_Click(object sender, EventArgs e)
        {
            switch (selected[0])
            {
                case "Countries":
                    switch (selected[1])
                    {
                        case "4X5":
                            new MemoCountries(lang).Show();
                            break;
                    }
                    break;
                case "Colors":
                    switch (selected[1])
                    {
                        case "6X7":
                            new MemoColors(lang).Show();
                            break;
                    }
                    break;
            }
        }

        private void Counties_CheckedChanged(object sender, EventArgs e)
        {
            selected[0] = "Countries";
            for (int i = 0; i < CountriesSizes.Length; i++)
            {
                if (CountriesSizes[i] == selected[1]) { break; }
                else { selected[1] = CountriesSizes[0]; Desk4x5.Select(); selected[1] = "4X5"; break; }
            }
            Desk6x7.Enabled = false;
            Desk5x6.Enabled = false;
            Desk4x5.Enabled = true;
        }

        private void Colors_CheckedChanged(object sender, EventArgs e)
        {
            selected[0] = "Colors";
            for (int i = 0; i < ColorsSizes.Length; i++)
            {
                if (ColorsSizes[i] == selected[1]) { break; }
                else { selected[1] = ColorsSizes[0]; Desk6x7.Select(); selected[1] = "6X7"; break; }
            }
            Desk6x7.Enabled = true;
            Desk5x6.Enabled = false;
            Desk4x5.Enabled = false;
        }
    }
}
