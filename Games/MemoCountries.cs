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

        private static MemoCard[] cards = new MemoCard[20];
        public void RandomizeCards()
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                MemoCard card1 = cards[random.Next(0, 20)];
                MemoCard card2 = cards[random.Next(0, 20)];
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
                card1.INITIALIZED = true;
                card2.INITIALIZED = true;
            }
        }
        public MemoCountries()
        {
            InitializeComponent(); 
            cards = new MemoCard[20] {Card1, Card2, Card3, Card4, Card5,
                                      Card6, Card7, Card8, Card9, Card10,
                                      Card11, Card12, Card13, Card14, Card15,
                                      Card16, Card17, Card18, Card19, Card20};
            foreach(var card in cards)
            {
                card.BackColor = Color.FromArgb(224224224);
            }
            RandomizeCards();
        }
        int opened = 0;
        MemoCard? fst;
        MemoCard? snd;
        int closed = 0;
        private void Card_Click(object sender, EventArgs e)
        {
            MemoCard card = sender as MemoCard;
            if(card == null)
            {
                return;
            }
            card.Text = card.CardObject.ToString();
            if (opened == 0)
            {
                card.State = MemoCard.MemoCardStates.Opened;
                card.BackColor = Color.Aqua;
                fst = card;
                opened++;
            }
            else if(opened == 1)
            {
                card.State = MemoCard.MemoCardStates.Opened;
                card.BackColor = Color.Aqua;
                snd = card;
                opened--;
                for(int i = 0; i < cards.Length; i++)
                {
                    if(cards[i].State != MemoCard.MemoCardStates.Opened) cards[i].Enabled = false;
                }
                Check.Enabled = true;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (fst.CardObject == snd.CardObject)
            {
                fst.State = MemoCard.MemoCardStates.Paired;
                snd.State = MemoCard.MemoCardStates.Paired;
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
                fst.State = MemoCard.MemoCardStates.Closed;
                snd.State = MemoCard.MemoCardStates.Closed;
                fst.BackColor = Color.FromArgb(224224224);
                snd.BackColor = Color.FromArgb(224224224);
            }
            fst = null;
            snd = null;
            for (int i = 0; i < cards.Length; i++)
            {
                if(cards[i].State == MemoCard.MemoCardStates.Closed) cards[i].Enabled = true;
            }
            Check.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
