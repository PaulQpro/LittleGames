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
    public partial class MemoColors : Form
    {
        public enum MemoColorsEnum
        {
            Red,//255,0,0
            Green,//0,255,05610b6
            Blue,//0,0,255
            Yellow,//255,255,0
            Cyan,//0,255,255
            Purple,//255,0,255
            Black,//0,0,0
            White,//255,255,255
            Gray,//127,127,127
            Teal,//0,255,127
            WinBlue,//0,127,255
            LGreen,//127,255,0
            Orange,//255,127,0
            Violet,//127,0,255
            Magneta,//255,0,127
            DarkViolet,//127,0,127
            Olive,//127,127,0
            DarkDiamond,//0,127,127
            DarkBlood,//127,0,0
            Emerald,//0,127,0
            NightBlue,//0,0,127
            Mahagony//147,64,68
        }
        private static MemoCardColors[] cards = new MemoCardColors[42];
        public void RandomizeCards()
        {
            Random random = new Random();
            for (int i = 0; i < 21; i++)
            {
                MemoCardColors card1 = cards[random.Next(0, 42)];
                MemoCardColors card2 = cards[random.Next(0, 42)];
                while (true)
                {
                    while (card1.Name == card2.Name)
                    {
                        card1 = cards[random.Next(0, 42)];
                        card2 = cards[random.Next(0, 42)];
                    }
                    while (card1.INITIALIZED)
                    {
                        card1 = cards[random.Next(0, 42)];
                    }
                    while (card2.INITIALIZED)
                    {
                        card2 = cards[random.Next(0, 42)];
                    }
                    if (card1.Name != card2.Name)
                    {
                        break;
                    }
                }
                card1.Pair = i;
                card2.Pair = i;
                card1.color = (MemoColorsEnum)i;
                card2.color = (MemoColorsEnum)i;
                card1.INITIALIZED = true;
                card2.INITIALIZED = true;
                Console.WriteLine(i + "=" + card1.color + ":" + card2.color);
            }
        }
        string lang;
        public MemoColors(string lang)
        {
            this.lang = lang;
            DefaultLang = new($"Lang\\{lang}.resx");
            MemoCLang = new($"Lang\\Memo\\Colors\\{lang}.resx");
            InitializeComponent();
            CloseBtn.Text = DefaultLang.GetString("Close");
            Check.Text = DefaultLang.GetString("Check");
            cards = new MemoCardColors[42] { Card1, Card2, Card3, Card4, Card5, Card6, Card7,
                                             Card8, Card9, Card10, Card11, Card12, Card13, Card14,
                                             Card15, Card16, Card17, Card18, Card19, Card20, Card21,
                                             Card22, Card23, Card24, Card25, Card26, Card27, Card28,
                                             Card29, Card30, Card31, Card32, Card33, Card34, Card35,
                                             Card36, Card37, Card38, Card39, Card40, Card41,Card42 };
            foreach (var card in cards)
            {
                card.BackColor = Color.FromArgb(224224224);
                card.Text = MemoCLang.GetString("Card");
            }
            RandomizeCards();
        }
        ResXResourceSet DefaultLang;
        ResXResourceSet MemoCLang;
        int opened = 0;
        MemoCardColors? fst = null;
        MemoCardColors? snd = null;
        int closed = 0;
        private void Card_Click(object sender, EventArgs e)
        {
            MemoCardColors card = sender as MemoCardColors;
            if (card == null)
            {
                return;
            }
            switch (card.color)
            {
                case MemoColorsEnum.Red:
                    card.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case MemoColorsEnum.Green:
                    card.BackColor = Color.FromArgb(0, 255, 0);
                    break;
                case MemoColorsEnum.Blue:
                    card.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case MemoColorsEnum.Yellow:
                    card.BackColor = Color.FromArgb(255, 255, 0);
                    break;
                case MemoColorsEnum.Cyan:
                    card.BackColor = Color.FromArgb(0, 255, 255);
                    break;
                case MemoColorsEnum.Purple:
                    card.BackColor = Color.FromArgb(255, 0, 255);
                    break;
                case MemoColorsEnum.Black:
                    card.BackColor = Color.FromArgb(0, 0, 0);
                    break;
                case MemoColorsEnum.White:
                    card.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case MemoColorsEnum.Gray:
                    card.BackColor = Color.FromArgb(127, 127, 127);
                    break;
                case MemoColorsEnum.Teal:
                    card.BackColor = Color.FromArgb(0, 255, 127);
                    break;
                case MemoColorsEnum.WinBlue:
                    card.BackColor = Color.FromArgb(0, 127, 255);
                    break;
                case MemoColorsEnum.LGreen:
                    card.BackColor = Color.FromArgb(255, 127, 0);
                    break;
                case MemoColorsEnum.Orange:
                    card.BackColor = Color.FromArgb(127, 255, 0);
                    break;
                case MemoColorsEnum.Violet:
                    card.BackColor = Color.FromArgb(127, 0, 255);
                    break;
                case MemoColorsEnum.Magneta:
                    card.BackColor = Color.FromArgb(255, 0, 127);
                    break;
                case MemoColorsEnum.DarkViolet:
                    card.BackColor = Color.FromArgb(127, 0, 127);
                    break;
                case MemoColorsEnum.Olive:
                    card.BackColor = Color.FromArgb(127, 127, 0);
                    break;
                case MemoColorsEnum.DarkDiamond:
                    card.BackColor = Color.FromArgb(0, 127, 127);
                    break;
                case MemoColorsEnum.DarkBlood:
                    card.BackColor = Color.FromArgb(127, 0, 0);
                    break;
                case MemoColorsEnum.Emerald:
                    card.BackColor = Color.FromArgb(0, 127, 0);
                    break;
                case MemoColorsEnum.NightBlue:
                    card.BackColor = Color.FromArgb(0, 0, 127);
                    break;
                case MemoColorsEnum.Mahagony:
                    card.BackColor = Color.FromArgb(147, 64, 68);
                    break;
                default:
                    break;
            }
            if (opened == 0)
            {
                card.State = MemoCardStates.Opened;
                fst = card;
                opened++;
            }
            else if (opened == 1)
            {
                if (card != fst)
                {
                    card.State = MemoCardStates.Opened;
                    snd = card;
                    opened--;
                    for (int i = 0; i < cards.Length; i++)
                    {
                        if (cards[i].State != MemoCardStates.Opened) cards[i].Enabled = false;
                    }
                    Check.Enabled = true;
                }
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if(fst == null || snd == null)
            {
                opened = 0;
                return;
            }
            if (fst.color == snd.color)
            {
                fst.State = MemoCardStates.Paired;
                snd.State = MemoCardStates.Paired;
                fst.Enabled = false;
                snd.Enabled = false;
                closed += 2;
                if (closed == 42)
                {
                    MessageBox.Show("You Won!");
                }
            }
            else
            {
                fst.State = MemoCardStates.Closed;
                snd.State = MemoCardStates.Closed;
                fst.BackColor = Color.FromArgb(224224224);
                snd.BackColor = Color.FromArgb(224224224);
            }
            fst = null;
            snd = null;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].State == MemoCardStates.Closed) cards[i].Enabled = true;
            }
            Check.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}