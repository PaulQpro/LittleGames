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

namespace LittleGames.Games
{
    public partial class MemoCountries : Form
    {
        public enum MemoObjects
        {
            Russia,
            USA,
            UK,
            Germany,
            France,
            China,
            Sweden,
            Brazil,
            Italy,
            Egypt
        }

        private static MemoCardCountries[] cards = new MemoCardCountries[20];
        public void RandomizeCards()
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                MemoCardCountries card1 = cards[random.Next(0, 20)];
                MemoCardCountries card2 = cards[random.Next(0, 20)];
                while (true)
                {
                    while (card1.Name == card2.Name)
                    {
                        card1 = cards[random.Next(0, 20)];
                        card2 = cards[random.Next(0, 20)];
                    }
                    while (card1.INITIALIZED)
                    {
                        card1 = cards[random.Next(0, 20)];
                    }
                    while (card2.INITIALIZED)
                    {
                        card2 = cards[random.Next(0, 20)];
                    }
                    if(card1.Name != card2.Name)
                    {
                        break;
                    }
                }
                card1.CardObject = (MemoObjects?)i;
                card2.CardObject = (MemoObjects?)i;
                card1.Pair = i;
                card2.Pair = i;
                card1.INITIALIZED = true;
                card2.INITIALIZED = true;
            }
        }
        string lang;
        public MemoCountries(string lang)
        {
            this.lang = lang;
            DefaultLang = new($"Lang\\{lang}.resx");
            MemoCLang = new($"Lang\\Memo\\Countries\\{lang}.resx");
            InitializeComponent();
            CloseBtn.Text = DefaultLang.GetString("Close");
            Check.Text = DefaultLang.GetString("Check");
            cards = new MemoCardCountries[20] {Card1, Card2, Card3, Card4, Card5,
                                      Card6, Card7, Card8, Card9, Card10,
                                      Card11, Card12, Card13, Card14, Card15,
                                      Card16, Card17, Card18, Card19, Card20};
            foreach(var card in cards)
            {
                card.BackColor = Color.FromArgb(224224224);
                card.Text = MemoCLang.GetString("Card");
            }
            RandomizeCards();
        }
        ResXResourceSet DefaultLang;
        ResXResourceSet MemoCLang;
        int opened = 0;
        MemoCardCountries? fst;
        MemoCardCountries? snd;
        int closed = 0;
        private void Card_Click(object sender, EventArgs e)
        {
            MemoCardCountries card = sender as MemoCardCountries;
            if(card == null)
            {
                return;
            }
            card.Text = MemoCLang.GetString($"p{card.Pair+1}");
            if (opened == 0)
            {
                card.State = MemoCardStates.Opened;
                card.BackColor = Color.Aqua;
                fst = card;
                opened++;
            }
            else if(opened == 1)
            {
                card.State = MemoCardStates.Opened;
                card.BackColor = Color.Aqua;
                snd = card;
                opened--;
                for(int i = 0; i < cards.Length; i++)
                {
                    if(cards[i].State != MemoCardStates.Opened) cards[i].Enabled = false;
                }
                Check.Enabled = true;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (fst.CardObject == snd.CardObject)
            {
                fst.State = MemoCardStates.Paired;
                snd.State = MemoCardStates.Paired;
                fst.BackColor = Color.Gold;
                snd.BackColor = Color.Gold;
                fst.Enabled = false;
                snd.Enabled = false;
                closed += 2;
                if (closed == 20)
                {
                    MessageBox.Show("You Won!");
                }
            }
            else
            {
                fst.Text = "Card";
                snd.Text = "Card";
                fst.State = MemoCardStates.Closed;
                snd.State = MemoCardStates.Closed;
                fst.BackColor = Color.FromArgb(224224224);
                snd.BackColor = Color.FromArgb(224224224);
                fst.Text = MemoCLang.GetString("Card");
                snd.Text = MemoCLang.GetString("Card");
            }
            fst = null;
            snd = null;
            for (int i = 0; i < cards.Length; i++)
            {
                if(cards[i].State == MemoCardStates.Closed) cards[i].Enabled = true;
            }
            Check.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
