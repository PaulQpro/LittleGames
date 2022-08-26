using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleGames;
using LittleGames.Games;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleGames
{
    public partial class SelectionMenu : Form
    {
        void checkSelectionLangResX(string key)
        {
            if (SelectLang.GetString(key) == null) { MessageBox.Show("'" + key + "' Value doesn't exists in Lang\\Menu\\Games\\" + lang + ".resx\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close(); }
        }
        ResXResourceSet DefaultLang;
        ResXResourceSet SelectLang;
        public SelectionMenu(string lang)
        {
            this.lang = lang;
            DefaultLang = new($"Lang\\{lang}.resx");
            try
            {
                SelectLang = new($"Lang\\Menu\\Games\\{lang}.resx");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("File not found \"Lang\\Menu\\Games\\" + lang + ".resx\"\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close();
            }
            finally
            {
                SelectLang = new($"Lang\\Menu\\Games\\{lang}.resx");
            }
            checkSelectionLangResX("TicTacToe");checkSelectionLangResX("Memos");checkSelectionLangResX("SAS");checkSelectionLangResX("CS");checkSelectionLangResX("title");
            InitializeComponent();
            TicTacToe_start.Text = SelectLang.GetString("TicTacToe");
            Memo_Start.Text = SelectLang.GetString("Memos");
            SAS_Start.Text = SelectLang.GetString("SAS");
            CS.Text = SelectLang.GetString("CS");
            BackBtn.Text = DefaultLang.GetString("Back");
            Text = SelectLang.GetString("title");

        }
        string lang;

        private void TicTacToe_start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new TicTacToeStart(lang).ShowDialog(this);
        }

        private void Memo_Start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new MemoStart(lang).ShowDialog(this);
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }

        private void SAS_Start_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new SAS(lang).ShowDialog(this);
        }
    }
}
